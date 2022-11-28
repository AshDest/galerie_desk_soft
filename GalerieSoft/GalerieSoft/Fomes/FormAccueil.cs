using GalerieSoft.Configs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalerieSoft.Fomes
{
    public partial class FormAccueil : MetroFramework.Forms.MetroForm
    {
        private ConnexionType connexionType;
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void FormAccueil_Load(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show("Echec de Connexion a la Base de Données : " + ex.Message, "CONNECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1("1");
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Terminal2 fr = new Terminal2("2");
            fr.Show();
        }

        private void typeDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeProduit fr = new TypeProduit();
            fr.ShowDialog();
        }

        private void term1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    term2.Focus();
                    break;
            }
        }

        private void term2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    term3.Focus();
                    break;
                case Keys.Left:
                    term1.Focus();
                    break;
            }
        }

        private void term3_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    term2.Focus();
                    break;
            }
        }
    }
}
