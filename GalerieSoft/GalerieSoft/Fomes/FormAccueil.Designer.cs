namespace GalerieSoft.Fomes
{
    partial class FormAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            this.term1 = new System.Windows.Forms.Button();
            this.term2 = new System.Windows.Forms.Button();
            this.term3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parametrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // term1
            // 
            this.term1.BackColor = System.Drawing.Color.White;
            this.term1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.term1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.term1.Image = ((System.Drawing.Image)(resources.GetObject("term1.Image")));
            this.term1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.term1.Location = new System.Drawing.Point(52, 109);
            this.term1.Name = "term1";
            this.term1.Size = new System.Drawing.Size(188, 81);
            this.term1.TabIndex = 1;
            this.term1.Text = "DEPOT BEAUF";
            this.term1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.term1.UseVisualStyleBackColor = false;
            this.term1.Click += new System.EventHandler(this.button1_Click);
            this.term1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.term1_KeyDown);
            // 
            // term2
            // 
            this.term2.BackColor = System.Drawing.Color.White;
            this.term2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.term2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.term2.Image = ((System.Drawing.Image)(resources.GetObject("term2.Image")));
            this.term2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.term2.Location = new System.Drawing.Point(287, 109);
            this.term2.Name = "term2";
            this.term2.Size = new System.Drawing.Size(188, 81);
            this.term2.TabIndex = 2;
            this.term2.Text = "DEPOT DAFAKO";
            this.term2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.term2.UseVisualStyleBackColor = false;
            this.term2.Click += new System.EventHandler(this.button2_Click);
            this.term2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.term2_KeyDown);
            // 
            // term3
            // 
            this.term3.BackColor = System.Drawing.Color.White;
            this.term3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.term3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.term3.Image = ((System.Drawing.Image)(resources.GetObject("term3.Image")));
            this.term3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.term3.Location = new System.Drawing.Point(521, 109);
            this.term3.Name = "term3";
            this.term3.Size = new System.Drawing.Size(188, 81);
            this.term3.TabIndex = 3;
            this.term3.Text = "DEPOT SHEKINAH";
            this.term3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.term3.UseVisualStyleBackColor = false;
            this.term3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.term3_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrageToolStripMenuItem,
            this.utilisateursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(23, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parametrageToolStripMenuItem
            // 
            this.parametrageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeDesProduitsToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.parametrageToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parametrageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("parametrageToolStripMenuItem.Image")));
            this.parametrageToolStripMenuItem.Name = "parametrageToolStripMenuItem";
            this.parametrageToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.parametrageToolStripMenuItem.Text = "Parametrage";
            // 
            // typeDesProduitsToolStripMenuItem
            // 
            this.typeDesProduitsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("typeDesProduitsToolStripMenuItem.Image")));
            this.typeDesProduitsToolStripMenuItem.Name = "typeDesProduitsToolStripMenuItem";
            this.typeDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.typeDesProduitsToolStripMenuItem.Text = "Type des Produits";
            this.typeDesProduitsToolStripMenuItem.Click += new System.EventHandler(this.typeDesProduitsToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fermerToolStripMenuItem.Image")));
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.fermerToolStripMenuItem.Text = "Fermer";
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnUtilisateurToolStripMenuItem});
            this.utilisateursToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilisateursToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("utilisateursToolStripMenuItem.Image")));
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs";
            // 
            // ajouterUnUtilisateurToolStripMenuItem
            // 
            this.ajouterUnUtilisateurToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterUnUtilisateurToolStripMenuItem.Image")));
            this.ajouterUnUtilisateurToolStripMenuItem.Name = "ajouterUnUtilisateurToolStripMenuItem";
            this.ajouterUnUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.ajouterUnUtilisateurToolStripMenuItem.Text = "Ajouter un Utilisateur";
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 218);
            this.Controls.Add(this.term3);
            this.Controls.Add(this.term2);
            this.Controls.Add(this.term1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Green;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAccueil";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Resizable = false;
            this.Text = "FORTUNA BUSINESS";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button term1;
        private System.Windows.Forms.Button term2;
        private System.Windows.Forms.Button term3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parametrageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeDesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnUtilisateurToolStripMenuItem;
    }
}