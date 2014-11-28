namespace presentation.Forms
{
    partial class FrmAjouterVoiture
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
            this.btn_ajoutVoiture = new System.Windows.Forms.Button();
            this.btn_ajoutVoiture_fermer = new System.Windows.Forms.Button();
            this.tbx_ajouttbx_ajoutVoiture_annee = new System.Windows.Forms.TextBox();
            this.tbx_ajoutVoiture_immatriculation = new System.Windows.Forms.TextBox();
            this.tbx_ajoutVoiture_Marque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ajoutPersonne_titre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ajoutVoiture
            // 
            this.btn_ajoutVoiture.Location = new System.Drawing.Point(453, 386);
            this.btn_ajoutVoiture.Name = "btn_ajoutVoiture";
            this.btn_ajoutVoiture.Size = new System.Drawing.Size(112, 35);
            this.btn_ajoutVoiture.TabIndex = 17;
            this.btn_ajoutVoiture.Text = "Ajouter";
            this.btn_ajoutVoiture.UseVisualStyleBackColor = true;
            this.btn_ajoutVoiture.Click += new System.EventHandler(this.btn_ajoutVoiture_Click);
            // 
            // btn_ajoutVoiture_fermer
            // 
            this.btn_ajoutVoiture_fermer.Location = new System.Drawing.Point(332, 386);
            this.btn_ajoutVoiture_fermer.Name = "btn_ajoutVoiture_fermer";
            this.btn_ajoutVoiture_fermer.Size = new System.Drawing.Size(115, 35);
            this.btn_ajoutVoiture_fermer.TabIndex = 16;
            this.btn_ajoutVoiture_fermer.Text = "Fermer";
            this.btn_ajoutVoiture_fermer.UseVisualStyleBackColor = true;
            this.btn_ajoutVoiture_fermer.Click += new System.EventHandler(this.btn_ajoutVoiture_fermer_Click);
            // 
            // tbx_ajouttbx_ajoutVoiture_annee
            // 
            this.tbx_ajouttbx_ajoutVoiture_annee.Location = new System.Drawing.Point(205, 287);
            this.tbx_ajouttbx_ajoutVoiture_annee.Name = "tbx_ajouttbx_ajoutVoiture_annee";
            this.tbx_ajouttbx_ajoutVoiture_annee.Size = new System.Drawing.Size(255, 20);
            this.tbx_ajouttbx_ajoutVoiture_annee.TabIndex = 15;
            // 
            // tbx_ajoutVoiture_immatriculation
            // 
            this.tbx_ajoutVoiture_immatriculation.Location = new System.Drawing.Point(205, 231);
            this.tbx_ajoutVoiture_immatriculation.Name = "tbx_ajoutVoiture_immatriculation";
            this.tbx_ajoutVoiture_immatriculation.Size = new System.Drawing.Size(255, 20);
            this.tbx_ajoutVoiture_immatriculation.TabIndex = 14;
            // 
            // tbx_ajoutVoiture_Marque
            // 
            this.tbx_ajoutVoiture_Marque.Location = new System.Drawing.Point(204, 183);
            this.tbx_ajoutVoiture_Marque.Name = "tbx_ajoutVoiture_Marque";
            this.tbx_ajoutVoiture_Marque.Size = new System.Drawing.Size(255, 20);
            this.tbx_ajoutVoiture_Marque.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Année :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Immatriculation :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Marque :";
            // 
            // lbl_ajoutPersonne_titre
            // 
            this.lbl_ajoutPersonne_titre.AutoSize = true;
            this.lbl_ajoutPersonne_titre.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajoutPersonne_titre.Location = new System.Drawing.Point(151, 62);
            this.lbl_ajoutPersonne_titre.Name = "lbl_ajoutPersonne_titre";
            this.lbl_ajoutPersonne_titre.Size = new System.Drawing.Size(336, 58);
            this.lbl_ajoutPersonne_titre.TabIndex = 9;
            this.lbl_ajoutPersonne_titre.Text = "Ajouter une voiture";
            // 
            // FrmAjouterVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(649, 483);
            this.Controls.Add(this.btn_ajoutVoiture);
            this.Controls.Add(this.btn_ajoutVoiture_fermer);
            this.Controls.Add(this.tbx_ajouttbx_ajoutVoiture_annee);
            this.Controls.Add(this.tbx_ajoutVoiture_immatriculation);
            this.Controls.Add(this.tbx_ajoutVoiture_Marque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ajoutPersonne_titre);
            this.Name = "FrmAjouterVoiture";
            this.Text = "Ajouter une voiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajoutVoiture;
        private System.Windows.Forms.Button btn_ajoutVoiture_fermer;
        private System.Windows.Forms.TextBox tbx_ajouttbx_ajoutVoiture_annee;
        private System.Windows.Forms.TextBox tbx_ajoutVoiture_immatriculation;
        private System.Windows.Forms.TextBox tbx_ajoutVoiture_Marque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ajoutPersonne_titre;
    }
}