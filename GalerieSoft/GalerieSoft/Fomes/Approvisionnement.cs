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
        string _depot;

        public Approvisionnement(string depot)
        {
            _depot = depot;
            InitializeComponent();
        }

        private void Approvisionnement_Load(object sender, EventArgs e)
        {
            txtDate.Format = DateTimePickerFormat.Custom;
            txtDate.CustomFormat = "yyyy-MM-dd";
            cmbProduit.DataSource = Glossaire.Instance.LoadStringWere("Designation", Constants.Tables.PRODUITS, _depot);
            dataGrid.DataSource = Glossaire.Instance.LoadGridWhere(Constants.Views.V_LISTE_APPROVISIONNEMENT, "DateApprov", txtDate.Text);
            txtCode.Text = "AP00" + Glossaire.Instance.Nouveau(Constants.Tables.APPROVISIONNEMENT, _depot).ToString();
            _initCmbState = true;
        }

        private void cmbProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initCmbState)
            {
                _codeProduit = Glossaire.Instance.SelectString(Constants.Tables.PRODUITS, cmbProduit.Text, "Designation");
                txtCodeProduit.Text = Glossaire.Instance.SelectString(Constants.Tables.PRODUITS, cmbProduit.Text, "Designation");
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
                        Depot = int.Parse(_depot)
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
