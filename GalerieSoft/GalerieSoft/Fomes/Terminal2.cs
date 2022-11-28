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
    public partial class Terminal2 : MetroFramework.Forms.MetroForm
    {
        private string _codeProduit = null;
        private string _prixtotal = null;
        private bool _initCmbState = false;
        private ConnexionType connexionType;
        private Detailvente vente = null;

        string _depot;
        private int _currentQte = 0;
        public Terminal2(string depoy = null)
        {
            _depot = depoy;
            InitializeComponent();
        }

        private void Terminal2_Load(object sender, EventArgs e)
        {
            try
            {
                cmbProduit.DataSource = Glossaire.Instance.LoadStringWere("Designation", Constants.Tables.PRODUITS, _depot);
                txtCodeVente.Text = "DP0200" + Glossaire.Instance.Nouveau(Constants.Tables.VENTE, _depot).ToString();
                cmbProduit.Focus();
                _initCmbState = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de Connexion a la Base de Données : " + ex.Message, "CONNECTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void typeProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeProduit fr = new TypeProduit();
            fr.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListProduit fr = new ListProduit(_depot);
            fr.ShowDialog();
        }

        private void categorieProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategorieProduit fr = new CategorieProduit();
            fr.ShowDialog();
        }

        private void approvisionnementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Approvisionnement fr = new Approvisionnement(_depot);
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
                        NomClient = null,
                        NumClient = null,
                        TotalPaie = 0,
                        Situation = 1,
                        Produit = _codeProduit,
                        Quantite = txtQte.Value,
                        Depot = int.Parse(_depot)
                    };
                    if(_currentQte > txtQte.Value)
                    {
                        Glossaire.Instance.ActionVente(vente, 1);
                        Glossaire.Instance.ActionVente(vente, 2);
                        resetFields(1);
                        MessageBox.Show("Enregistrement Reussi", "SAVING MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridData.DataSource = Glossaire.Instance.LoadGridWhere(Constants.Views.V_LIST_DETAIL_VENTE, "CodeVente", txtCodeVente.Text);
                        _prixtotal = Glossaire.Instance.SelectTotalValue(txtCodeVente.Text) + " FC";
                        txtPrixTot.Text = Glossaire.Instance.SelectTotalValue(txtCodeVente.Text) + " FC";
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

        private void resetFields(int var)
        {
            if (var == 1)
            {
                txtCode.Text = "";
                cmbProduit.Text = "";
                txtQte.Value = 1;
            }
            else
            {
                txtCodeVente.Text = "DEP0200" + Glossaire.Instance.Nouveau(Constants.Tables.VENTE, _depot).ToString();
                gridData.DataSource = Glossaire.Instance.LoadGridWhere(Constants.Views.V_LIST_DETAIL_VENTE, "CodeVente", txtCodeVente.Text);
                txtPrixTot.Text = "FC";
            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            using (InfoVente fr = new InfoVente(string.Format("{0}", txtCodeVente.Text), string.Format(_prixtotal)))
            {
                fr.ShowDialog();
            }
            resetFields(2);
            cmbProduit.Focus();
        }
    }
}
