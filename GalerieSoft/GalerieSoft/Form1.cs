using GalerieSoft.Configs;
using GalerieSoft.Fomes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalerieSoft
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private ConnexionType connexionType;
        public Form1()
        {
            InitializeComponent();
        }

        private void paramètreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void typeProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeProduit fr = new TypeProduit();
            fr.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Connection connexion = new Connection();

                connexion.Server = "DESKTOP-OLAHFQB";
                connexion.Database = "db_galerie";
                connexion.User = "sa";
                connexion.Password = "destinashuza";

                ImplementeConnection.Instance.Initialise(connexion, connexionType);
                ImplementeConnection.Instance.Con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Echec de Connexion a la Base de Données : " + ex.Message, "CONNECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListProduit fr = new ListProduit();
            fr.ShowDialog();
        }

        private void categorieProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategorieProduit fr = new CategorieProduit();
            fr.ShowDialog();
        }
    }
}
