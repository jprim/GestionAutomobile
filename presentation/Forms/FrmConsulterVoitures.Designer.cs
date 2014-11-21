namespace presentation.Forms
{
    partial class FrmConsulterVoitures
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
            this.lbl_consultationVoiture_titre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbx_affichageVoiture_NomP = new System.Windows.Forms.ListBox();
            this.lbx_affichageVoiture_trier = new System.Windows.Forms.ListBox();
            this.dgv_affichageVoiture = new System.Windows.Forms.DataGridView();
            this.btn_afficheVoiture_fermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_affichageVoiture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_consultationVoiture_titre
            // 
            this.lbl_consultationVoiture_titre.AutoSize = true;
            this.lbl_consultationVoiture_titre.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_consultationVoiture_titre.Location = new System.Drawing.Point(77, 20);
            this.lbl_consultationVoiture_titre.Name = "lbl_consultationVoiture_titre";
            this.lbl_consultationVoiture_titre.Size = new System.Drawing.Size(419, 57);
            this.lbl_consultationVoiture_titre.TabIndex = 0;
            this.lbl_consultationVoiture_titre.Text = "Affichage des voitures";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de la personne :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trier sur :";
            // 
            // lbx_affichageVoiture_NomP
            // 
            this.lbx_affichageVoiture_NomP.FormattingEnabled = true;
            this.lbx_affichageVoiture_NomP.Location = new System.Drawing.Point(168, 142);
            this.lbx_affichageVoiture_NomP.Name = "lbx_affichageVoiture_NomP";
            this.lbx_affichageVoiture_NomP.Size = new System.Drawing.Size(169, 17);
            this.lbx_affichageVoiture_NomP.TabIndex = 3;
            // 
            // lbx_affichageVoiture_trier
            // 
            this.lbx_affichageVoiture_trier.FormattingEnabled = true;
            this.lbx_affichageVoiture_trier.Items.AddRange(new object[] {
            "Nom",
            "Immatriculation",
            "Puissance",
            "Date de mise en service",
            "Louée"});
            this.lbx_affichageVoiture_trier.Location = new System.Drawing.Point(451, 142);
            this.lbx_affichageVoiture_trier.Name = "lbx_affichageVoiture_trier";
            this.lbx_affichageVoiture_trier.Size = new System.Drawing.Size(169, 17);
            this.lbx_affichageVoiture_trier.TabIndex = 4;
            // 
            // dgv_affichageVoiture
            // 
            this.dgv_affichageVoiture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_affichageVoiture.Location = new System.Drawing.Point(47, 184);
            this.dgv_affichageVoiture.Name = "dgv_affichageVoiture";
            this.dgv_affichageVoiture.Size = new System.Drawing.Size(585, 205);
            this.dgv_affichageVoiture.TabIndex = 5;
            // 
            // btn_afficheVoiture_fermer
            // 
            this.btn_afficheVoiture_fermer.Location = new System.Drawing.Point(303, 395);
            this.btn_afficheVoiture_fermer.Name = "btn_afficheVoiture_fermer";
            this.btn_afficheVoiture_fermer.Size = new System.Drawing.Size(128, 30);
            this.btn_afficheVoiture_fermer.TabIndex = 6;
            this.btn_afficheVoiture_fermer.Text = "Fermer";
            this.btn_afficheVoiture_fermer.UseVisualStyleBackColor = true;
            this.btn_afficheVoiture_fermer.Click += new System.EventHandler(this.btn_afficheVoiture_fermer_Click);
            // 
            // FrmConsulterVoitures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(711, 449);
            this.Controls.Add(this.btn_afficheVoiture_fermer);
            this.Controls.Add(this.dgv_affichageVoiture);
            this.Controls.Add(this.lbx_affichageVoiture_trier);
            this.Controls.Add(this.lbx_affichageVoiture_NomP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_consultationVoiture_titre);
            this.Name = "FrmConsulterVoitures";
            this.Text = "Affichage des voitures";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_affichageVoiture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_consultationVoiture_titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbx_affichageVoiture_NomP;
        private System.Windows.Forms.ListBox lbx_affichageVoiture_trier;
        private System.Windows.Forms.DataGridView dgv_affichageVoiture;
        private System.Windows.Forms.Button btn_afficheVoiture_fermer;
    }
}