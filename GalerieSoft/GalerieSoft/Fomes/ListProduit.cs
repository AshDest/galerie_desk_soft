﻿using System;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produits fr = new Produits();
            fr.ShowDialog();
        }
    }
}
