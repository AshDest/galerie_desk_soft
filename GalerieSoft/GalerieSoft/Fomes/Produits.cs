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
    public partial class Produits : MetroFramework.Forms.MetroForm
    {
        private Produit produit = null;
        private int _idCategorie = 0;
        private int _idType = 0;
        private bool _initCmbState = false;

        string _depot;
        public Produits(string depot)
        {
            _depot = depot;
            InitializeComponent();
        }

        private void Produits_Load(object sender, EventArgs e)
        {
            //cmbCategorie.DataSource = Glossaire.Instance.LoadString("Designation", Constants.Tables.CATEGORIE_PRODUIT);
            cmbType.DataSource = Glossaire.Instance.LoadString("Designation", Constants.Tables.TYPE_PRODUIT);
            _initCmbState = true;
            switch (_depot)
            {
                case "1":
                    txtDepot.Text = "DEPOT BEAUF";
                    break;
                case "2":
                    txtDepot.Text = "DEPOT DAFOKO";
                    break;
                case "3":
                    txtDepot.Text = "DEPOT SHEKINAH";
                    break;
                default:
                    txtDepot.Text = "";
                    break;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            savedata();
        }

        private void savedata()
        {
            try
            {
                if (IsNotEmpty(1))
                {
                    produit = new Produit
                    {
                        Code = txtCode.Text,
                        Designation = txtDesignation.Text,
                        Typeproduit = _idType,
                        Depo = int.Parse(_depot),
                        Prix = float.Parse(txtPrix.Text)
                    };
                    Glossaire.Instance.Produits(produit, 1);
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

        private void RestAllFiels()
        {
            txtCode.Text = "";
            txtDesignation.Text = "";
            txtPrix.Text = "";
            _initCmbState = false;
        }

        private bool IsNotEmpty(int rank)
        {
            if (rank == 1)
            {
                if (!string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(txtDesignation.Text) && !string.IsNullOrEmpty(txtPrix.Text))
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initCmbState)
            {
                _idType = Glossaire.Instance.SelectId(Constants.Tables.TYPE_PRODUIT, cmbType.Text, "Designation");
            }
            else
            {
                cmbType.SelectedIndex = -1;
            }
        }

        private void cmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (_initCmbState)
            //{
            //    _idCategorie = Glossaire.Instance.SelectId(Constants.Tables.CATEGORIE_PRODUIT, cmbCategorie.Text, "Designation");
            //}
            //else
            //{
            //    cmbCategorie.SelectedIndex = -1;
            //}
        }

        private void txtDesignation_KeyDown(object sender, KeyEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtDesignation.Text))
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        txtPrix.Focus();
                        break;
                    case Keys.Enter:
                        savedata();
                        break;
                }
            }
        }

        private void txtPrix_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrix.Text))
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        cmbType.Focus();
                        break;
                    case Keys.Up:
                        txtDesignation.Focus();
                        break;
                    case Keys.Enter:
                        savedata();
                        break;
                }
            }
        }

        private void cmbType_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbType.Text))
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        metroButton1.Focus();
                        break;
                    case Keys.Up:
                        txtPrix.Focus();
                        break;
                    case Keys.Enter:
                        savedata();
                        break;
                }
            }
        }

        private void Produits_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    savedata();
                    break;
            }
        }
    }
}
