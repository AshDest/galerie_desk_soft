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
    public partial class CategorieProduit : MetroFramework.Forms.MetroForm
    {
        private CategorieProduits cat = null;
        public CategorieProduit()
        {
            InitializeComponent();
        }

        private void CategorieProduit_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = Glossaire.Instance.LoadGrid(Constants.Tables.CATEGORIE_PRODUIT, "Id");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDesignation.Text != "")
                {
                    cat = new CategorieProduits
                    {
                        Designation = txtDesignation.Text
                    };
                    Glossaire.Instance.Categorie_Produit(cat, 1);
                    dataGrid.DataSource = Glossaire.Instance.LoadGrid(Constants.Tables.CATEGORIE_PRODUIT, "Id");
                    MessageBox.Show("Enregistrement Reussi", "SAVING MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDesignation.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'Enregistrement : " + ex.Message, "SAVING MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDesignation.Text = this.dataGrid.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
