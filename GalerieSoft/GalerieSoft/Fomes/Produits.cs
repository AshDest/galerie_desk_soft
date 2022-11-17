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
        public Produits()
        {
            InitializeComponent();
        }

        private void Produits_Load(object sender, EventArgs e)
        {
            cmbCategorie.DataSource = Glossaire.Instance.LoadString("Designation", Constants.Tables.CATEGORIE_PRODUIT);
            cmbType.DataSource = Glossaire.Instance.LoadString("Designation", Constants.Tables.TYPE_PRODUIT);
            _initCmbState = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

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
            if (_initCmbState)
            {
                _idCategorie = Glossaire.Instance.SelectId(Constants.Tables.CATEGORIE_PRODUIT, cmbCategorie.Text, "Designation");
            }
            else
            {
                cmbCategorie.SelectedIndex = -1;
            }
        }
    }
}
