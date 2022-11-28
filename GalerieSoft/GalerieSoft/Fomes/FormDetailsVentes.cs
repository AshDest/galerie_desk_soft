using GalerieSoft.Configs;
using GalerieSoft.Data;
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
    public partial class FormDetailsVentes : MetroFramework.Forms.MetroForm
    {
        private string _codeProduit = null;
        private bool _initCmbState = false;
        string _code;
        string _depot;
        private int _currentQte = 0;
        public FormDetailsVentes(string code, string depot)
        {
            _code = code;
            _depot = depot;
            InitializeComponent();
        }

        private void FormDetailsVentes_Load(object sender, EventArgs e)
        {
            gridData.DataSource = Glossaire.Instance.LoadGridWhere(Constants.Views.V_LIST_DETAIL_VENTE, "CodeVente", _code);
            cmbProduit.DataSource = Glossaire.Instance.LoadStringWere("Designation", Constants.Tables.PRODUITS, _depot);
            _initCmbState = true;
        }

        private void gridData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = this.gridData.CurrentRow.Cells[0].Value.ToString();
            cmbProduit.Text = this.gridData.CurrentRow.Cells[1].Value.ToString();
            txtQte.Value = decimal.Parse(this.gridData.CurrentRow.Cells[2].Value.ToString());
        }

        private void cmbProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initCmbState)
            {
                _codeProduit = Glossaire.Instance.SelectString(Constants.Tables.PRODUITS, cmbProduit.Text, "Designation");
                txtCode.Text = _codeProduit;
                _currentQte = Glossaire.Instance.CurrentQte(Constants.Tables.PRODUITS, cmbProduit.Text, "Designation");
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
                if (!string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(cmbProduit.Text) && !string.IsNullOrEmpty(_code) && !string.IsNullOrEmpty(txtQte.Text))
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
}
