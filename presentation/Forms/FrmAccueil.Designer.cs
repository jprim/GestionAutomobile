namespace presentation.Forms
{
    partial class FrmAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccueil));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneVoitureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneVoitureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.louerUneVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendreUneVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toutesLesVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toutesLesPersonnesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.importerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.gérerToolStripMenuItem,
            this.consultationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importerToolStripMenuItem,
            this.exporterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voitureToolStripMenuItem,
            this.personnesToolStripMenuItem,
            this.locationsToolStripMenuItem});
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.gérerToolStripMenuItem.Text = "Gérer";
            // 
            // voitureToolStripMenuItem
            // 
            this.voitureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneVoitureToolStripMenuItem,
            this.supprimerUneVoitureToolStripMenuItem});
            this.voitureToolStripMenuItem.Name = "voitureToolStripMenuItem";
            this.voitureToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.voitureToolStripMenuItem.Text = "Voitures";
            // 
            // ajouterUneVoitureToolStripMenuItem
            // 
            this.ajouterUneVoitureToolStripMenuItem.Name = "ajouterUneVoitureToolStripMenuItem";
            this.ajouterUneVoitureToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ajouterUneVoitureToolStripMenuItem.Text = "Ajouter une voiture";
            this.ajouterUneVoitureToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneVoitureToolStripMenuItem_Click);
            // 
            // supprimerUneVoitureToolStripMenuItem
            // 
            this.supprimerUneVoitureToolStripMenuItem.Name = "supprimerUneVoitureToolStripMenuItem";
            this.supprimerUneVoitureToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.supprimerUneVoitureToolStripMenuItem.Text = "Supprimer une voiture";
            this.supprimerUneVoitureToolStripMenuItem.Click += new System.EventHandler(this.supprimerUneVoitureToolStripMenuItem_Click);
            // 
            // personnesToolStripMenuItem
            // 
            this.personnesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneVoitureToolStripMenuItem1,
            this.supprimerUneVoitureToolStripMenuItem1});
            this.personnesToolStripMenuItem.Name = "personnesToolStripMenuItem";
            this.personnesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.personnesToolStripMenuItem.Text = "Personnes";
            // 
            // ajouterUneVoitureToolStripMenuItem1
            // 
            this.ajouterUneVoitureToolStripMenuItem1.Name = "ajouterUneVoitureToolStripMenuItem1";
            this.ajouterUneVoitureToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.ajouterUneVoitureToolStripMenuItem1.Text = "Ajouter une personne";
            this.ajouterUneVoitureToolStripMenuItem1.Click += new System.EventHandler(this.ajouterUneVoitureToolStripMenuItem1_Click);
            // 
            // supprimerUneVoitureToolStripMenuItem1
            // 
            this.supprimerUneVoitureToolStripMenuItem1.Name = "supprimerUneVoitureToolStripMenuItem1";
            this.supprimerUneVoitureToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.supprimerUneVoitureToolStripMenuItem1.Text = "Supprimer une personne";
            this.supprimerUneVoitureToolStripMenuItem1.Click += new System.EventHandler(this.supprimerUneVoitureToolStripMenuItem1_Click);
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.louerUneVoitureToolStripMenuItem,
            this.rendreUneVoitureToolStripMenuItem});
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.locationsToolStripMenuItem.Text = "Locations";
            // 
            // louerUneVoitureToolStripMenuItem
            // 
            this.louerUneVoitureToolStripMenuItem.Name = "louerUneVoitureToolStripMenuItem";
            this.louerUneVoitureToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.louerUneVoitureToolStripMenuItem.Text = "Louer une voiture";
            this.louerUneVoitureToolStripMenuItem.Click += new System.EventHandler(this.louerUneVoitureToolStripMenuItem_Click);
            // 
            // rendreUneVoitureToolStripMenuItem
            // 
            this.rendreUneVoitureToolStripMenuItem.Name = "rendreUneVoitureToolStripMenuItem";
            this.rendreUneVoitureToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.rendreUneVoitureToolStripMenuItem.Text = "Rendre une voiture";
            this.rendreUneVoitureToolStripMenuItem.Click += new System.EventHandler(this.rendreUneVoitureToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toutesLesVoituresToolStripMenuItem,
            this.toutesLesPersonnesToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // toutesLesVoituresToolStripMenuItem
            // 
            this.toutesLesVoituresToolStripMenuItem.Name = "toutesLesVoituresToolStripMenuItem";
            this.toutesLesVoituresToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.toutesLesVoituresToolStripMenuItem.Text = "Toutes les voitures";
            this.toutesLesVoituresToolStripMenuItem.Click += new System.EventHandler(this.toutesLesVoituresToolStripMenuItem_Click);
            // 
            // toutesLesPersonnesToolStripMenuItem
            // 
            this.toutesLesPersonnesToolStripMenuItem.Name = "toutesLesPersonnesToolStripMenuItem";
            this.toutesLesPersonnesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.toutesLesPersonnesToolStripMenuItem.Text = "Toutes les personnes";
            this.toutesLesPersonnesToolStripMenuItem.Click += new System.EventHandler(this.toutesLesPersonnesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(763, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // importerToolStripMenuItem
            // 
            this.importerToolStripMenuItem.Name = "importerToolStripMenuItem";
            this.importerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importerToolStripMenuItem.Text = "Importer";
            this.importerToolStripMenuItem.Click += new System.EventHandler(this.importerToolStripMenuItem_Click);
            // 
            // exporterToolStripMenuItem
            // 
            this.exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            this.exporterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exporterToolStripMenuItem.Text = "Exporter";
            this.exporterToolStripMenuItem.Click += new System.EventHandler(this.exporterToolStripMenuItem_Click);
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 314);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAccueil";
            this.Text = "Gestion Automobile";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneVoitureToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneVoitureToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toutesLesVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toutesLesPersonnesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem louerUneVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendreUneVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterToolStripMenuItem;
    }
}