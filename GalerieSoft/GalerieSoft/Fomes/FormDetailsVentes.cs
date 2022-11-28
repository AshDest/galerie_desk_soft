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
        string _code;
        public FormDetailsVentes(string code)
        {
            _code = code;
            InitializeComponent();
        }

        private void FormDetailsVentes_Load(object sender, EventArgs e)
        {
            gridData.DataSource = Glossaire.Instance.LoadGridWhere(Constants.Views.V_LIST_DETAIL_VENTE, "CodeVente", _code);
        }
    }
}
