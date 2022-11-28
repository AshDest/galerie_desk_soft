using GalerieSoft.Configs;
using GalerieSoft.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalerieSoft.Data
{
    public class Glossaire
    {
        const string DirectoryLog = "Log";
        private static string _connectionString, _host, _db, _user, _pwd;
        private static Glossaire glos;
        private SqlDataAdapter adapter;
        private SqlConnection sqlCon;
        public static string currentDB;

        #region Initialisation component
        public static Glossaire Instance
        {
            get
            {
                if (glos == null)
                {
                    glos = new Glossaire();
                }
                return glos;
            }
        }

        private static void SetParameter(IDbCommand cmd, string name, DbType type, int length, object paramValue)
        {

            IDbDataParameter a = cmd.CreateParameter();
            a.ParameterName = name;
            a.Size = length;
            a.DbType = type;

            if (paramValue == null)
            {
                if (!a.IsNullable)
                {
                    a.DbType = DbType.String;
                }
                a.Value = DBNull.Value;
            }
            else
                a.Value = paramValue;

            cmd.Parameters.Add(a);
        }

        public void InitializeConnexion()
        {
            try
            {
                if (ImplementeConnection.Instance.Con.State == ConnectionState.Closed)
                    ImplementeConnection.Instance.Con.Open();
            }
            catch (Exception)
            {

            }
        }
        #endregion

        public DataTable LoadGrid(string table, string orderBy)
        {
            InitializeConnexion();
            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM " + table + " ORDER BY " + orderBy + " DESC";
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter((SqlCommand)cmd);
                adapter.Fill(dt);

                return dt;
            }
        }
        public List<string> LoadString(string field, string table)
        {
            InitializeConnexion();

            List<string> list = new List<string>();

            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT " + field + " FROM " + table + " ORDER BY " + field + " ";

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(dr[field].ToString());
                }
                dr.Dispose();
            }
            return list;
        }

        public List<string> LoadStringWere(string field, string table, string depot)
        {
            InitializeConnexion();

            List<string> list = new List<string>();

            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT " + field + " FROM " + table + " where Depot = " + depot + " ORDER BY " + field + " ";

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(dr[field].ToString());
                }
                dr.Dispose();
            }
            return list;
        }
        public int SelectId(string table, string field, string refer)
        {
            InitializeConnexion();

            int id = 0;

            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT Id FROM " + table + " WHERE " + refer + " = '" + field + "'";
                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id = Convert.ToInt32(dr["Id"].ToString());
                }

                dr.Dispose();
            }
            return id;
        }

        public int CurrentQte(string table, string field, string refer)
        {
            InitializeConnexion();

            int qte = 0;

            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT Qte_stock FROM " + table + " WHERE " + refer + " = '" + field + "'";
                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    qte = Convert.ToInt32(dr["Qte_stock"].ToString());
                }

                dr.Dispose();
            }
            return qte;
        }

        public string SelectTotalValue(string field)
        {
            InitializeConnexion();

            string tot = null;

            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT Total FROM tVente WHERE Code = '" + field + "'";
                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    tot = dr["Total"].ToString();
                }

                dr.Dispose();
            }
            return tot;
        }


        public string SelectString(string table, string field, string refer)
        {
            InitializeConnexion();

            string code = null;

            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT Code FROM " + table + " WHERE " + refer + " = '" + field + "'";
                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    code = dr["Code"].ToString();
                }

                dr.Dispose();
            }
            return code;
        }

        public DataTable LoadGridWhere(string table, string field, string where)
        {
            InitializeConnexion();

            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM " + table + " WHERE " + field + " = '" + where + "'";
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter((SqlCommand)cmd);
                adapter.Fill(dt);

                return dt;
            }
        }

        public DataTable LoadGridWhereLike(string table, string field, string where, string like, string controls)
        {
            InitializeConnexion();

            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM " + table + " WHERE " + field + " = '" + where + "' AND " + like + " LIKE '%" + controls + "%'";
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter((SqlCommand)cmd);
                adapter.Fill(dt);

                return dt;
            }
        }

        public int Nouveau(string table, string depot)
        {
            int id = 0;

            InitializeConnexion();
            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) as lastId FROM " + table + " where Depot = " + depot + "";

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    id = Convert.ToInt32(rd["lastId"].ToString()) + 1;
                }

                rd.Dispose();
            }
            return id;
        }


        public void Type_Produit(TypeProduits tp, int action)
        {
            InitializeConnexion();
            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_typeProduit";
                cmd.CommandType = CommandType.StoredProcedure;
                SetParameter(cmd, "@designation", DbType.String, 50, tp.Designation);
                SetParameter(cmd, "@action", DbType.Int32, 1, action);
                cmd.ExecuteNonQuery();
            }
        }
        public void Categorie_Produit(CategorieProduits cat, int action)
        {
            InitializeConnexion();
            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_categorieProduit";
                cmd.CommandType = CommandType.StoredProcedure;
                SetParameter(cmd, "@designation", DbType.String, 50, cat.Designation);
                SetParameter(cmd, "@action", DbType.Int32, 1, action);
                cmd.ExecuteNonQuery();
            }
        }

        public void Produits(Produit p, int action)
        {
            InitializeConnexion();
            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_produit";
                cmd.CommandType = CommandType.StoredProcedure;
                SetParameter(cmd, "@code", DbType.String, 50, p.Code);
                SetParameter(cmd, "@designation", DbType.String, 50, p.Designation);
                SetParameter(cmd, "@typeproduit", DbType.Int32, 50, p.Typeproduit);
                SetParameter(cmd, "@depot", DbType.Int32, 50, p.Depo);
                SetParameter(cmd, "@prix", DbType.Double, 50, p.Prix);
                SetParameter(cmd, "@action", DbType.Int32, 1, action);
                cmd.ExecuteNonQuery();
            }
        }

        public void Approvisionnement(Approvisionnements ap, int action)
        {
            InitializeConnexion();
            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_approvisionnemen";
                cmd.CommandType = CommandType.StoredProcedure;
                SetParameter(cmd, "@code", DbType.String, 50, ap.Code);
                SetParameter(cmd, "@produit", DbType.String, 50, ap.Produit);
                SetParameter(cmd, "@quantite", DbType.String, 50, ap.Qte);
                SetParameter(cmd, "@prix", DbType.String, 50, ap.Pu);
                SetParameter(cmd, "@depot", DbType.Int32, 1, ap.Depot);
                SetParameter(cmd, "@action", DbType.Int32, 1, action);
                cmd.ExecuteNonQuery();
            }
        }

        public void ActionVente(Detailvente vt, int action)
        {
            InitializeConnexion();
            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_vente";
                cmd.CommandType = CommandType.StoredProcedure;
                SetParameter(cmd, "@code", DbType.String, 100, vt.Code);
                SetParameter(cmd, "@nomclient", DbType.String, 50, vt.NomClient);
                SetParameter(cmd, "@numclient", DbType.String, 50, vt.NumClient);
                SetParameter(cmd, "@produit", DbType.String, 50, vt.Produit);
                SetParameter(cmd, "@quantite", DbType.Int32, 50, vt.Quantite);
                SetParameter(cmd, "@totalpaie", DbType.Double, 50, vt.TotalPaie);
                SetParameter(cmd, "@situation", DbType.String, 50, vt.Situation);
                SetParameter(cmd, "@depot", DbType.Int32, 1, vt.Depot);
                SetParameter(cmd, "@action", DbType.Int32, 1, action);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
