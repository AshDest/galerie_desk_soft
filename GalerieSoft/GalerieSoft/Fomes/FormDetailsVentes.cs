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
    public partial class FormDetailsVentes : MetroFramework.Forms.MetroForm
    {
        private string _codeProduit = null;
        private bool _initCmbState = false;
        string _code;
        string _depot;
        private int _currentQte = 0;
        private Detailvente vente = null;
        private int Id_d_vente = 0;
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
            Id_d_vente = int.Parse(this.gridData.CurrentRow.Cells[6].Value.ToString());
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
        private void resetFields(int var)
        {
            if (var == 1)
            {
                txtCode.Text = "";
                cmbProduit.Text = "";
                txtQte.Value = 1;
            }

        }

        private void btnPanier_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsNotEmpty(1))
                {
                    vente = new Detailvente
                    {
                        Code = _code,
                        NomClient = null,
                        NumClient = null,
                        TotalPaie = 0,
                        Situation = 1,
                        Produit = _codeProduit,
                        Quantite = txtQte.Value,
                        Depot = int.Parse(_depot),
                        Id = Id_d_vente
                        
                    };
                    if (_currentQte > txtQte.Value)
                    {
                        Glossaire.Instance.ActionVente(vente, 3);
                        resetFields(1);
                        MessageBox.Show("Enregistrement Reussi", "SAVING MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridData.DataSource = Glossaire.Instance.LoadGridWhere(Constants.Views.V_LIST_DETAIL_VENTE, "CodeVente", _code);
                        cmbProduit.Focus();
                    }
                    else
                    {
                        MessageBox.Show("La Quantité Saisie Supérieur au Stock", "SAVING MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
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
