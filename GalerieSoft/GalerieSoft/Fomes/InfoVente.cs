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
    public partial class InfoVente : MetroFramework.Forms.MetroForm
    {
        string _code, _total;
        public InfoVente(string code, string total)
        {
            _code = code;
            _total = total;
            InitializeComponent();
        }

        private void InfoVente_Load(object sender, EventArgs e)
        {

        }
    }
}
