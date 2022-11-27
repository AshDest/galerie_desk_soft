namespace GalerieSoft.Fomes
{
    partial class Produits
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtPrix = new System.Windows.Forms.MaskedTextBox();
            this.txtDepot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(28, 92);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(356, 23);
            this.txtCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Designation produit";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation.Location = new System.Drawing.Point(28, 156);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(356, 23);
            this.txtDesignation.TabIndex = 2;
            this.txtDesignation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesignation_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix Unitaire";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 23;
            this.cmbType.Location = new System.Drawing.Point(28, 284);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(356, 29);
            this.cmbType.TabIndex = 6;
            this.cmbType.UseSelectable = true;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            this.cmbType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbType_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type produit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dépot";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(107, 413);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(209, 23);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Enregistrer";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtPrix
            // 
            this.txtPrix.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.Location = new System.Drawing.Point(28, 223);
            this.txtPrix.Mask = "000000000000";
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.PromptChar = ' ';
            this.txtPrix.Size = new System.Drawing.Size(356, 26);
            this.txtPrix.TabIndex = 11;
            this.txtPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrix_KeyDown);
            // 
            // txtDepot
            // 
            this.txtDepot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepot.Location = new System.Drawing.Point(28, 355);
            this.txtDepot.Name = "txtDepot";
            this.txtDepot.ReadOnly = true;
            this.txtDepot.Size = new System.Drawing.Size(356, 23);
            this.txtDepot.TabIndex = 12;
            // 
            // Produits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 464);
            this.Controls.Add(this.txtDepot);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Produits";
            this.Resizable = false;
            this.Text = "Produits";
            this.Load += new System.EventHandler(this.Produits_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Produits_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton metroButton1;
        public System.Windows.Forms.MaskedTextBox txtPrix;
        public System.Windows.Forms.TextBox txtCode;
        public System.Windows.Forms.TextBox txtDesignation;
        public MetroFramework.Controls.MetroComboBox cmbType;
        public System.Windows.Forms.TextBox txtDepot;
    }
}