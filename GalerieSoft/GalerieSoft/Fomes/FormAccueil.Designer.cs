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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parametrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(52, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 81);
            this.button1.TabIndex = 16;
            this.button1.Text = "DEPOT BEAUF";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(287, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 81);
            this.button2.TabIndex = 17;
            this.button2.Text = "DEPOT DAFAKO";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(521, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 81);
            this.button3.TabIndex = 18;
            this.button3.Text = "DEPOT SHEKINAH";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parametrageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeDesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnUtilisateurToolStripMenuItem;
    }
}