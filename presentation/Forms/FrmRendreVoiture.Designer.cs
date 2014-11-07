namespace presentation.Forms
{
    partial class FrmRendreVoiture
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
            this.lbx_rendre_voiture = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ajoutPersonne_titre = new System.Windows.Forms.Label();
            this.btn_rendre = new System.Windows.Forms.Button();
            this.btn_rendre_fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_rendre_voiture
            // 
            this.lbx_rendre_voiture.FormattingEnabled = true;
            this.lbx_rendre_voiture.Location = new System.Drawing.Point(245, 167);
            this.lbx_rendre_voiture.Name = "lbx_rendre_voiture";
            this.lbx_rendre_voiture.Size = new System.Drawing.Size(229, 30);
            this.lbx_rendre_voiture.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 33);
            this.label1.TabIndex = 28;
            this.label1.Text = "Voiture à rendre :";
            // 
            // lbl_ajoutPersonne_titre
            // 
            this.lbl_ajoutPersonne_titre.AutoSize = true;
            this.lbl_ajoutPersonne_titre.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajoutPersonne_titre.Location = new System.Drawing.Point(110, 52);
            this.lbl_ajoutPersonne_titre.Name = "lbl_ajoutPersonne_titre";
            this.lbl_ajoutPersonne_titre.Size = new System.Drawing.Size(308, 58);
            this.lbl_ajoutPersonne_titre.TabIndex = 27;
            this.lbl_ajoutPersonne_titre.Text = "Louer une voiture";
            // 
            // btn_rendre
            // 
            this.btn_rendre.Location = new System.Drawing.Point(366, 285);
            this.btn_rendre.Name = "btn_rendre";
            this.btn_rendre.Size = new System.Drawing.Size(112, 35);
            this.btn_rendre.TabIndex = 26;
            this.btn_rendre.Text = "Valider";
            this.btn_rendre.UseVisualStyleBackColor = true;
            // 
            // btn_rendre_fermer
            // 
            this.btn_rendre_fermer.Location = new System.Drawing.Point(245, 285);
            this.btn_rendre_fermer.Name = "btn_rendre_fermer";
            this.btn_rendre_fermer.Size = new System.Drawing.Size(115, 35);
            this.btn_rendre_fermer.TabIndex = 25;
            this.btn_rendre_fermer.Text = "Fermer";
            this.btn_rendre_fermer.UseVisualStyleBackColor = true;
            // 
            // FrmRendreVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 400);
            this.Controls.Add(this.lbx_rendre_voiture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ajoutPersonne_titre);
            this.Controls.Add(this.btn_rendre);
            this.Controls.Add(this.btn_rendre_fermer);
            this.Name = "FrmRendreVoiture";
            this.Text = "Rendre une voiture";
            this.Load += new System.EventHandler(this.FrmRendreVoiture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_rendre_voiture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ajoutPersonne_titre;
        private System.Windows.Forms.Button btn_rendre;
        private System.Windows.Forms.Button btn_rendre_fermer;
    }
}