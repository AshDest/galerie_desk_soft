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

        public void Type_Produit(TypeProduit tp, int action)
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
        public void Categorie_Produit(CategorieProduit cat, int action)
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
                SetParameter(cmd, "@typeproduit", DbType.String, 50, p.Typeproduit);
                SetParameter(cmd, "@categorie", DbType.String, 50, p.Categorieproduit);
                SetParameter(cmd, "@prix", DbType.String, 50, p.Prix);
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

        public void ActionVente(Vente vt, int action)
        {
            InitializeConnexion();
            using (IDbCommand cmd = ImplementeConnection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "sp_merge_vente";
                cmd.CommandType = CommandType.StoredProcedure;
                SetParameter(cmd, "@code", DbType.String, 50, ap.Code);
                SetParameter(cmd, "@datevente", DbType.String, 50, ap.Produit);
                SetParameter(cmd, "@nomclient", DbType.String, 50, ap.Qte);
                SetParameter(cmd, "@numclient", DbType.String, 50, ap.Pu);
                SetParameter(cmd, "@produit", DbType.String, 50, ap.Produit);
                SetParameter(cmd, "@quantite", DbType.String, 50, ap.Qte);
                SetParameter(cmd, "@prix", DbType.String, 50, ap.Pu);
                SetParameter(cmd, "@totalpaie", DbType.String, 50, ap.Produit);
                SetParameter(cmd, "@situation", DbType.String, 50, ap.Qte);
                SetParameter(cmd, "@action", DbType.Int32, 1, action);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
