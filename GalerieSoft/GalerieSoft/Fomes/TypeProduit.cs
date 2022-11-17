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
using GalerieSoft.Models;
namespace GalerieSoft.Fomes
{
    public partial class TypeProduit : MetroFramework.Forms.MetroForm
    {
        private TypeProduits type = null;
        public TypeProduit()
        {
            InitializeComponent();
        }

        private void TypeProduit_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = Glossaire.Instance.LoadGrid(Constants.Tables.TYPE_PRODUIT, "Id"); 
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtDesignation.Text!="")
                {
                    type = new TypeProduits
                    {
                        Designation = txtDesignation.Text
                    };
                    Glossaire.Instance.Type_Produit(type, 1);
                    dataGrid.DataSource = Glossaire.Instance.LoadGrid(Constants.Tables.TYPE_PRODUIT, "Id");
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
