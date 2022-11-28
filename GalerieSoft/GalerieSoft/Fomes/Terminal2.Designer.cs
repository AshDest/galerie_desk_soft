namespace GalerieSoft.Fomes
{
    partial class Terminal2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terminal2));
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridData = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCodeVente = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPrixTot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQte = new System.Windows.Forms.NumericUpDown();
            this.btnPanier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProduit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paramètreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvisionnementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paiementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeVentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeApprovisionnementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listePaimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDettesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorieProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQte)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(20, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1234, 288);
            this.panel3.TabIndex = 21;
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.AllowUserToResizeRows = false;
            this.gridData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4,
            this.CodeVente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridData.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridData.EnableHeadersVisualStyles = false;
            this.gridData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.Location = new System.Drawing.Point(13, 6);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridData.Size = new System.Drawing.Size(1205, 276);
            this.gridData.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Produit";
            this.Column1.HeaderText = "Num";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Designation";
            this.Column2.HeaderText = "Designation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Quantite";
            this.Column5.HeaderText = "Quantite";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Pu";
            this.Column3.HeaderText = "Prix unitaire";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Pt";
            this.Column4.HeaderText = "Prix Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // CodeVente
            // 
            this.CodeVente.DataPropertyName = "CodeVente";
            this.CodeVente.HeaderText = "Code Vente";
            this.CodeVente.Name = "CodeVente";
            this.CodeVente.ReadOnly = true;
            this.CodeVente.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.txtCodeVente);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtPrixTot);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 100);
            this.panel2.TabIndex = 20;
            // 
            // txtCodeVente
            // 
            this.txtCodeVente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeVente.Location = new System.Drawing.Point(13, 44);
            this.txtCodeVente.Name = "txtCodeVente";
            this.txtCodeVente.ReadOnly = true;
            this.txtCodeVente.Size = new System.Drawing.Size(261, 23);
            this.txtCodeVente.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1057, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 60);
            this.button2.TabIndex = 16;
            this.button2.Text = "Terminer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPrixTot
            // 
            this.txtPrixTot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrixTot.AutoSize = true;
            this.txtPrixTot.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixTot.Location = new System.Drawing.Point(948, 32);
            this.txtPrixTot.Name = "txtPrixTot";
            this.txtPrixTot.Size = new System.Drawing.Size(50, 33);
            this.txtPrixTot.TabIndex = 10;
            this.txtPrixTot.Text = "FC";
            this.txtPrixTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(898, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "TOTAL :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.txtQte);
            this.panel1.Controls.Add(this.btnPanier);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbProduit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 82);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtQte
            // 
            this.txtQte.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQte.Location = new System.Drawing.Point(702, 37);
            this.txtQte.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtQte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(145, 26);
            this.txtQte.TabIndex = 2;
            this.txtQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQte_KeyDown);
            // 
            // btnPanier
            // 
            this.btnPanier.BackColor = System.Drawing.Color.White;
            this.btnPanier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanier.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnPanier.Image = ((System.Drawing.Image)(resources.GetObject("btnPanier.Image")));
            this.btnPanier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanier.Location = new System.Drawing.Point(991, 12);
            this.btnPanier.Name = "btnPanier";
            this.btnPanier.Size = new System.Drawing.Size(174, 60);
            this.btnPanier.TabIndex = 15;
            this.btnPanier.Text = "Ajouter au Panier";
            this.btnPanier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPanier.UseVisualStyleBackColor = false;
            this.btnPanier.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(752, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pièces";
            // 
            // cmbProduit
            // 
            this.cmbProduit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProduit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProduit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduit.FormattingEnabled = true;
            this.cmbProduit.Location = new System.Drawing.Point(296, 37);
            this.cmbProduit.Name = "cmbProduit";
            this.cmbProduit.Size = new System.Drawing.Size(376, 25);
            this.cmbProduit.TabIndex = 1;
            this.cmbProduit.SelectedIndexChanged += new System.EventHandler(this.cmbProduit_SelectedIndexChanged);
            this.cmbProduit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProduit_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Code produit";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(13, 39);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(261, 23);
            this.txtCode.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Designation produit";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(740, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantite";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(907, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "INFO SUR LE PRODUIT";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètreToolStripMenuItem,
            this.approvisionnementToolStripMenuItem,
            this.financeToolStripMenuItem,
            this.visualisationToolStripMenuItem,
            this.paramètreToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 25);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paramètreToolStripMenuItem
            // 
            this.paramètreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.paramètreToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paramètreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paramètreToolStripMenuItem.Image")));
            this.paramètreToolStripMenuItem.Name = "paramètreToolStripMenuItem";
            this.paramètreToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.paramètreToolStripMenuItem.Text = "Actions";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.Image")));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // approvisionnementToolStripMenuItem
            // 
            this.approvisionnementToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvisionnementToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("approvisionnementToolStripMenuItem.Image")));
            this.approvisionnementToolStripMenuItem.Name = "approvisionnementToolStripMenuItem";
            this.approvisionnementToolStripMenuItem.Size = new System.Drawing.Size(153, 21);
            this.approvisionnementToolStripMenuItem.Text = "Approvisionnement";
            this.approvisionnementToolStripMenuItem.Click += new System.EventHandler(this.approvisionnementToolStripMenuItem_Click);
            // 
            // financeToolStripMenuItem
            // 
            this.financeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paiementToolStripMenuItem});
            this.financeToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("financeToolStripMenuItem.Image")));
            this.financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            this.financeToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.financeToolStripMenuItem.Text = "Finance";
            // 
            // paiementToolStripMenuItem
            // 
            this.paiementToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paiementToolStripMenuItem.Image")));
            this.paiementToolStripMenuItem.Name = "paiementToolStripMenuItem";
            this.paiementToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.paiementToolStripMenuItem.Text = "Paiement";
            // 
            // visualisationToolStripMenuItem
            // 
            this.visualisationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeVentesToolStripMenuItem,
            this.listeApprovisionnementsToolStripMenuItem,
            this.stockProduitsToolStripMenuItem,
            this.listePaimentToolStripMenuItem,
            this.listeDettesToolStripMenuItem});
            this.visualisationToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualisationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visualisationToolStripMenuItem.Image")));
            this.visualisationToolStripMenuItem.Name = "visualisationToolStripMenuItem";
            this.visualisationToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.visualisationToolStripMenuItem.Text = "Visualisation";
            // 
            // listeVentesToolStripMenuItem
            // 
            this.listeVentesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeVentesToolStripMenuItem.Image")));
            this.listeVentesToolStripMenuItem.Name = "listeVentesToolStripMenuItem";
            this.listeVentesToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.listeVentesToolStripMenuItem.Text = "Liste Ventes";
            // 
            // listeApprovisionnementsToolStripMenuItem
            // 
            this.listeApprovisionnementsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeApprovisionnementsToolStripMenuItem.Image")));
            this.listeApprovisionnementsToolStripMenuItem.Name = "listeApprovisionnementsToolStripMenuItem";
            this.listeApprovisionnementsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.listeApprovisionnementsToolStripMenuItem.Text = "Liste Approvisionnements";
            // 
            // stockProduitsToolStripMenuItem
            // 
            this.stockProduitsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockProduitsToolStripMenuItem.Image")));
            this.stockProduitsToolStripMenuItem.Name = "stockProduitsToolStripMenuItem";
            this.stockProduitsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.stockProduitsToolStripMenuItem.Text = "Stock Produits";
            // 
            // listePaimentToolStripMenuItem
            // 
            this.listePaimentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listePaimentToolStripMenuItem.Image")));
            this.listePaimentToolStripMenuItem.Name = "listePaimentToolStripMenuItem";
            this.listePaimentToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.listePaimentToolStripMenuItem.Text = "Liste Paiment";
            // 
            // listeDettesToolStripMenuItem
            // 
            this.listeDettesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeDettesToolStripMenuItem.Image")));
            this.listeDettesToolStripMenuItem.Name = "listeDettesToolStripMenuItem";
            this.listeDettesToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.listeDettesToolStripMenuItem.Text = "Liste Dettes";
            // 
            // paramètreToolStripMenuItem1
            // 
            this.paramètreToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produitsToolStripMenuItem,
            this.typeProduitToolStripMenuItem,
            this.categorieProduitToolStripMenuItem});
            this.paramètreToolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paramètreToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("paramètreToolStripMenuItem1.Image")));
            this.paramètreToolStripMenuItem1.Name = "paramètreToolStripMenuItem1";
            this.paramètreToolStripMenuItem1.Size = new System.Drawing.Size(99, 21);
            this.paramètreToolStripMenuItem1.Text = "Paramètre";
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("produitsToolStripMenuItem.Image")));
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.produitsToolStripMenuItem.Text = "Produits";
            this.produitsToolStripMenuItem.Click += new System.EventHandler(this.produitsToolStripMenuItem_Click);
            // 
            // typeProduitToolStripMenuItem
            // 
            this.typeProduitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("typeProduitToolStripMenuItem.Image")));
            this.typeProduitToolStripMenuItem.Name = "typeProduitToolStripMenuItem";
            this.typeProduitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.typeProduitToolStripMenuItem.Text = "Type Produit";
            this.typeProduitToolStripMenuItem.Visible = false;
            this.typeProduitToolStripMenuItem.Click += new System.EventHandler(this.typeProduitToolStripMenuItem_Click);
            // 
            // categorieProduitToolStripMenuItem
            // 
            this.categorieProduitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categorieProduitToolStripMenuItem.Image")));
            this.categorieProduitToolStripMenuItem.Name = "categorieProduitToolStripMenuItem";
            this.categorieProduitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.categorieProduitToolStripMenuItem.Text = "Categorie Produit";
            this.categorieProduitToolStripMenuItem.Visible = false;
            this.categorieProduitToolStripMenuItem.Click += new System.EventHandler(this.categorieProduitToolStripMenuItem_Click);
            // 
            // Terminal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 575);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Terminal2";
            this.Resizable = false;
            this.Text = "DEPOT DAFOKA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Terminal2_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQte)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroGrid gridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeVente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCodeVente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txtPrixTot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown txtQte;
        private System.Windows.Forms.Button btnPanier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProduit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paramètreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvisionnementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paiementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeVentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeApprovisionnementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listePaimentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDettesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorieProduitToolStripMenuItem;
    }
}