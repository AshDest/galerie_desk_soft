using GalerieSoft.Configs;
using GalerieSoft.Data;
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

namespace GalerieSoft.Fomes
{
    public partial class Approvisionnement : MetroFramework.Forms.MetroForm
    {
        private string _codeProduit = null;
        private bool _initCmbState = false;
        private Approvisionnements appro = null;
        public Approvisionnement()
        {
            InitializeComponent();
        }

        private void Approvisionnement_Load(object sender, EventArgs e)
        {
            cmbProduit.DataSource = Glossaire.Instance.LoadString("Designation", Constants.Tables.PRODUITS);
            _initCmbState = true;
        }

        private void cmbProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initCmbState)
            {
                _codeProduit = Glossaire.Instance.SelectString(Constants.Tables.PRODUITS, cmbProduit.Text, "Designation");
            }
            else
            {
                cmbProduit.SelectedIndex = -1;
            }
        }
        private bool IsNotEmpty(int rank)
        {
            if (rank == 1)
            {
                if (!string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(txtPrix.Text) && !string.IsNullOrEmpty(txtPrix.Text) && !string.IsNullOrEmpty(cmbProduit.Text))
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        private void RestAllFiels()
        {
            txtCode.Text = "";
            cmbProduit.Text = "";
            txtPrix.Text = "";
            txtQte.Text = "";
            _initCmbState = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNotEmpty(1))
                {
                    appro = new Approvisionnements
                    {
                        Code = txtCode.Text,
                        Produit = _codeProduit,
                        Qte = int.Parse(txtQte.Text),
                        Pu = float.Parse(txtPrix.Text),
                    };
                    Glossaire.Instance.Approvisionnement(appro, 1);
                    RestAllFiels();
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
    }
}
