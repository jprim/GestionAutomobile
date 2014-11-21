namespace presentation.Forms
{
    partial class FrmLouerVoiture
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
            this.btn_Louer = new System.Windows.Forms.Button();
            this.btn_louer_fermer = new System.Windows.Forms.Button();
            this.lbl_ajoutPersonne_titre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_louer_voiture = new System.Windows.Forms.ListBox();
            this.lbx_louer_personne = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Louer
            // 
            this.btn_Louer.Location = new System.Drawing.Point(406, 297);
            this.btn_Louer.Name = "btn_Louer";
            this.btn_Louer.Size = new System.Drawing.Size(112, 35);
            this.btn_Louer.TabIndex = 19;
            this.btn_Louer.Text = "Valider";
            this.btn_Louer.UseVisualStyleBackColor = true;
            // 
            // btn_louer_fermer
            // 
            this.btn_louer_fermer.Location = new System.Drawing.Point(285, 297);
            this.btn_louer_fermer.Name = "btn_louer_fermer";
            this.btn_louer_fermer.Size = new System.Drawing.Size(115, 35);
            this.btn_louer_fermer.TabIndex = 18;
            this.btn_louer_fermer.Text = "Fermer";
            this.btn_louer_fermer.UseVisualStyleBackColor = true;
            this.btn_louer_fermer.Click += new System.EventHandler(this.btn_louer_fermer_Click);
            // 
            // lbl_ajoutPersonne_titre
            // 
            this.lbl_ajoutPersonne_titre.AutoSize = true;
            this.lbl_ajoutPersonne_titre.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajoutPersonne_titre.Location = new System.Drawing.Point(132, 35);
            this.lbl_ajoutPersonne_titre.Name = "lbl_ajoutPersonne_titre";
            this.lbl_ajoutPersonne_titre.Size = new System.Drawing.Size(308, 58);
            this.lbl_ajoutPersonne_titre.TabIndex = 20;
            this.lbl_ajoutPersonne_titre.Text = "Louer une voiture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 33);
            this.label2.TabIndex = 22;
            this.label2.Text = "Personne :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Voiture :";
            // 
            // lbx_louer_voiture
            // 
            this.lbx_louer_voiture.FormattingEnabled = true;
            this.lbx_louer_voiture.Location = new System.Drawing.Point(231, 147);
            this.lbx_louer_voiture.Name = "lbx_louer_voiture";
            this.lbx_louer_voiture.Size = new System.Drawing.Size(229, 30);
            this.lbx_louer_voiture.TabIndex = 23;
            // 
            // lbx_louer_personne
            // 
            this.lbx_louer_personne.FormattingEnabled = true;
            this.lbx_louer_personne.Location = new System.Drawing.Point(231, 195);
            this.lbx_louer_personne.Name = "lbx_louer_personne";
            this.lbx_louer_personne.Size = new System.Drawing.Size(228, 30);
            this.lbx_louer_personne.TabIndex = 24;
            // 
            // FrmLouerVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 383);
            this.Controls.Add(this.lbx_louer_personne);
            this.Controls.Add(this.lbx_louer_voiture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ajoutPersonne_titre);
            this.Controls.Add(this.btn_Louer);
            this.Controls.Add(this.btn_louer_fermer);
            this.Name = "FrmLouerVoiture";
            this.Text = "Louer une voiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Louer;
        private System.Windows.Forms.Button btn_louer_fermer;
        private System.Windows.Forms.Label lbl_ajoutPersonne_titre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_louer_voiture;
        private System.Windows.Forms.ListBox lbx_louer_personne;
    }
}