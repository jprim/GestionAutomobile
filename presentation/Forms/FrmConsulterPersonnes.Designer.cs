namespace presentation.Forms
{
    partial class FrmConsulterPersonnes
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
            this.btn_affichePersonnes_fermer = new System.Windows.Forms.Button();
            this.dgv_affichagePersonnes = new System.Windows.Forms.DataGridView();
            this.lbx_affichagePersonne_trier = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_consultationPersonne_titre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_affichagePersonnes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_affichePersonnes_fermer
            // 
            this.btn_affichePersonnes_fermer.Location = new System.Drawing.Point(281, 397);
            this.btn_affichePersonnes_fermer.Name = "btn_affichePersonnes_fermer";
            this.btn_affichePersonnes_fermer.Size = new System.Drawing.Size(128, 30);
            this.btn_affichePersonnes_fermer.TabIndex = 13;
            this.btn_affichePersonnes_fermer.Text = "Fermer";
            this.btn_affichePersonnes_fermer.UseVisualStyleBackColor = true;
            this.btn_affichePersonnes_fermer.Click += new System.EventHandler(this.btn_affichePersonnes_fermer_Click);
            // 
            // dgv_affichagePersonnes
            // 
            this.dgv_affichagePersonnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_affichagePersonnes.Location = new System.Drawing.Point(25, 186);
            this.dgv_affichagePersonnes.Name = "dgv_affichagePersonnes";
            this.dgv_affichagePersonnes.Size = new System.Drawing.Size(585, 205);
            this.dgv_affichagePersonnes.TabIndex = 12;
            // 
            // lbx_affichagePersonne_trier
            // 
            this.lbx_affichagePersonne_trier.FormattingEnabled = true;
            this.lbx_affichagePersonne_trier.Items.AddRange(new object[] {
            "Nom",
            "Ville"});
            this.lbx_affichagePersonne_trier.Location = new System.Drawing.Point(104, 142);
            this.lbx_affichagePersonne_trier.Name = "lbx_affichagePersonne_trier";
            this.lbx_affichagePersonne_trier.Size = new System.Drawing.Size(169, 17);
            this.lbx_affichagePersonne_trier.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Trier sur :";
            // 
            // lbl_consultationPersonne_titre
            // 
            this.lbl_consultationPersonne_titre.AutoSize = true;
            this.lbl_consultationPersonne_titre.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_consultationPersonne_titre.Location = new System.Drawing.Point(94, 28);
            this.lbl_consultationPersonne_titre.Name = "lbl_consultationPersonne_titre";
            this.lbl_consultationPersonne_titre.Size = new System.Drawing.Size(446, 57);
            this.lbl_consultationPersonne_titre.TabIndex = 7;
            this.lbl_consultationPersonne_titre.Text = "Affichage des personnes";
            // 
            // FrmConsulterPersonnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 455);
            this.Controls.Add(this.btn_affichePersonnes_fermer);
            this.Controls.Add(this.dgv_affichagePersonnes);
            this.Controls.Add(this.lbx_affichagePersonne_trier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_consultationPersonne_titre);
            this.Name = "FrmConsulterPersonnes";
            this.Text = "FrmConsulterPersonne";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_affichagePersonnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_affichePersonnes_fermer;
        private System.Windows.Forms.DataGridView dgv_affichagePersonnes;
        private System.Windows.Forms.ListBox lbx_affichagePersonne_trier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_consultationPersonne_titre;
    }
}