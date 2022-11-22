using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalerieSoft.Configs
{
    public class Constants
    {
        public class Tables
        {
            public const string TYPE_PRODUIT = "tTypeProduit";
            public const string CATEGORIE_PRODUIT = "tCategorie";
            public const string APPROVISIONNEMENT = "tGarage";
            public const string PRODUITS = "tProduit";
            public const string PAIEMENT = "tVehicule";
            public const string VENTE = "tEntretient";
            public const string DETAILVENTE = "tMvm_Entretient";
            //public const string DETAIL_ENTRETIENT = "DetailEntretient";
        }

        public class Views
        {
            public const string V_LIST_PRODUITS = "v_list_produit";
            public const string V_LISTE_APPROVISIONNEMENT = "v_list_approvisionnement";
            public const string V_LIST_DETAIL_VENTE = "v_detailVente";
            public const string V_LIST_HOME_DATA = "v_home_data";
            public const string V_LIST_FALSE_VEHICULE = "v_list_false_vehicule";
            public const string V_LIST_ENTRETIEN_DASH = "v_Entretien_dash";
        }
        //About SERVER CONFIG
        public static string InitialDirectory = "C://charroi";
        public static string SeverPassWord = "C://charroi/password.txt";
        public static string ServerUsername = "C://charroi/username.txt";
        public static string Server = "C://charroi/server.txt";
        public static string dbName = "C://charroi/dbname.txt";
        public static string PortNumber = "C://charroi/port.txt";
        public static string NameCompagny = "C://charroi/namecompagny.txt";
    }
}
