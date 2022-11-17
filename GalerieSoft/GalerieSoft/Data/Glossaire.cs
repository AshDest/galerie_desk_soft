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
                SetParameter(cmd, "@categorie", DbType.Int32, 50, p.Categorieproduit);
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
                SetParameter(cmd, "@datevente", DbType.Date, 50, vt.DateVente);
                SetParameter(cmd, "@nomclient", DbType.String, 50, vt.NomClient);
                SetParameter(cmd, "@numclient", DbType.String, 50, vt.NumClient);
                SetParameter(cmd, "@produit", DbType.String, 50, vt.Produit);
                SetParameter(cmd, "@quantite", DbType.Int32, 50, vt.Quantite);
                SetParameter(cmd, "@prix", DbType.Double, 50, vt.PrixU);
                SetParameter(cmd, "@totalpaie", DbType.Double, 50, vt.TotalPaie);
                SetParameter(cmd, "@situation", DbType.String, 50, vt.Situation);
                SetParameter(cmd, "@action", DbType.Int32, 1, action);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
