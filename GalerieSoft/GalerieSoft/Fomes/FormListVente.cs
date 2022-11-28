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
    }
}
