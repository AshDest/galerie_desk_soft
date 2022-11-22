using GalerieSoft.Configs;
using GalerieSoft.Data;
using GalerieSoft.Fomes;
using GalerieSoft.Models;
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
        private string _codeProduit = null;
        private bool _initCmbState = false;
        private ConnexionType connexionType;
        private Detailvente vente = null;
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

                cmbProduit.DataSource = Glossaire.Instance.LoadString("Designation", Constants.Tables.PRODUITS);
                _initCmbState = true;
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

        private void approvisionnementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Approvisionnement fr = new Approvisionnement();
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNotEmpty(1))
                {
                    vente = new Detailvente
                    {
                        Code = txtCodeVente.Text,
                        Produit = _codeProduit,
                        Quantite = txtQte.Value
                    };
                    Glossaire.Instance.ActionVente(vente, 1);
                    //RestAllFiels();
                    MessageBox.Show("Enregistrement Reussi", "SAVING MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Certain champ du formulaire sont obligatoire", "SAVING MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'Enregistrement : " + ex.Message, "SAVING MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsNotEmpty(int rank)
        {
            if (rank == 1)
            {
                if (!string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(cmbProduit.Text) && !string.IsNullOrEmpty(txtCodeVente.Text) && !string.IsNullOrEmpty(txtQte.Text))
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        private void cmbProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initCmbState)
            {
                _codeProduit = Glossaire.Instance.SelectString(Constants.Tables.PRODUITS, cmbProduit.Text, "Designation");
                txtCode.Text = _codeProduit;
            }
            else
            {
                cmbProduit.SelectedIndex = -1;
            }
        }
    }
}
