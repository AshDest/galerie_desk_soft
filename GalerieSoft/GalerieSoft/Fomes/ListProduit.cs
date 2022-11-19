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
    public partial class ListProduit : MetroFramework.Forms.MetroForm
    {
        public ListProduit()
        {
            InitializeComponent();
        }

        private void ListProduit_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = Glossaire.Instance.LoadGrid(Constants.Views.V_LIST_PRODUITS, "Code");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produits fr = new Produits();
            fr.ShowDialog();
            dataGrid.DataSource = Glossaire.Instance.LoadGrid(Constants.Views.V_LIST_PRODUITS, "Code");
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Produits fr = new Produits();
            fr.txtCode.Text = this.dataGrid.CurrentRow.Cells[0].Value.ToString();
            fr.txtDesignation.Text = this.dataGrid.CurrentRow.Cells[1].Value.ToString();
            fr.cmbType.Text = this.dataGrid.CurrentRow.Cells[2].Value.ToString();
            fr.cmbCategorie.Text = this.dataGrid.CurrentRow.Cells[3].Value.ToString();
            fr.txtPrix.Text = this.dataGrid.CurrentRow.Cells[5].Value.ToString();
            fr.ShowDialog();
            dataGrid.DataSource = Glossaire.Instance.LoadGrid(Constants.Views.V_LIST_PRODUITS, "Code");
        }
    }
}
