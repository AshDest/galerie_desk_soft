using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalerieSoft.Configs
{
    public enum ConnexionType
    {
        SQLServer,
        MySQL,
        PostGrsSQL,
        Oracle,
        Access
    }
    public class ImplementeConnection
    {
        private IDbConnection _con = null;
        private static ImplementeConnection _instance = null;

        public IDbConnection Con
        {
            get
            {
                return _con;
            }

            set
            {
                _con = value;
            }
        }

        public static ImplementeConnection Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ImplementeConnection();
                return _instance;
            }
        }

        public IDbConnection Initialise(Connection connexion, ConnexionType connexionType)
        {
            switch (connexionType)
            {
                case ConnexionType.SQLServer:
                    _con = new SqlConnection(string.Format("Data source={0};Initial catalog={1};User ID={2};Password={3}",
                        connexion.Server, connexion.Database, connexion.User, connexion.Password));
                    break;
                case ConnexionType.MySQL:
                    //_con = new MySqlConnection(string.Format("Server={0};Database={1};UserID={2};Password={3}",
                    //    connexion.Server, connexion.Database, connexion.User, connexion.Password));
                    break;
                case ConnexionType.PostGrsSQL:
                    //_con = new NpgsqlConnection(string.Format("Server={0};Database={1};Uid={2};Pwd={3};Port={4}",
                    //    connexion.Serveur, connexion.Database, connexion.User, connexion.Password, connexion.Port));
                    break;
                case ConnexionType.Oracle:
                    return null;
                case ConnexionType.Access:
                    return null;
            }
            //_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:/BDCharois/db_charroi.mdf;Integrated Security=True;Connect Timeout=30");
            //_con = new SqlConnection(@"Data source=DESKTOP-OLAHFQB;Initial catalog=db_charroi;User ID=sa;Password=destinashuza");

            //_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|db_charroi.mdf;Integrated Security=True;Connect Timeout=30");
            return _con;
        }
    }
}
