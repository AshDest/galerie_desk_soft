using GalerieSoft.Configs;
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
    }
}
