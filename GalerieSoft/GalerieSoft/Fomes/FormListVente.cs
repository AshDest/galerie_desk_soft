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
    public partial class FormListVente : MetroFramework.Forms.MetroForm
    {
        string _depot;
        public FormListVente(string depot)
        {
            _depot = depot;
            InitializeComponent();
        }

        private void FormListVente_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = Glossaire.Instance.LoadGridWhere(Constants.Views.V_LIST_VENTE, "Depot", _depot);          
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ckd.Checked = false;
            dataGrid.DataSource = Glossaire.Instance.LoadGridWhereLike(Constants.Views.V_LIST_VENTE, "Depot", _depot, "Code", txtSearch.Text);
        }

        private void ckd_CheckedChanged(object sender, EventArgs e)
        {
            if(ckd.Checked == true)
            {
                dataGrid.DataSource = Glossaire.Instance.LoadGridWhere(Constants.Views.V_LIST_VENTE, "Depot", _depot);
                txtSearch.Text = "";
            }

        }
    }
}
