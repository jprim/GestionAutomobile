namespace presentation.Forms
{
    partial class FrmAjouterPersonne
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
            this.lbl_ajoutPersonne_titre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_ajoutPersonne_nom = new System.Windows.Forms.TextBox();
            this.tbx_ajoutPersonne_prenom = new System.Windows.Forms.TextBox();
            this.tbx_ajoutPersonne_ville = new System.Windows.Forms.TextBox();
            this.btn_ajoutPersonne_fermer = new System.Windows.Forms.Button();
            this.btn_ajoutPersonne_ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ajoutPersonne_titre
            // 
            this.lbl_ajoutPersonne_titre.AutoSize = true;
            this.lbl_ajoutPersonne_titre.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajoutPersonne_titre.Location = new System.Drawing.Point(140, 40);
            this.lbl_ajoutPersonne_titre.Name = "lbl_ajoutPersonne_titre";
            this.lbl_ajoutPersonne_titre.Size = new System.Drawing.Size(376, 58);
            this.lbl_ajoutPersonne_titre.TabIndex = 0;
            this.lbl_ajoutPersonne_titre.Text = "Ajouter une personne";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ville :";
            // 
            // tbx_ajoutPersonne_nom
            // 
            this.tbx_ajoutPersonne_nom.Location = new System.Drawing.Point(227, 161);
            this.tbx_ajoutPersonne_nom.Name = "tbx_ajoutPersonne_nom";
            this.tbx_ajoutPersonne_nom.Size = new System.Drawing.Size(255, 20);
            this.tbx_ajoutPersonne_nom.TabIndex = 4;
            // 
            // tbx_ajoutPersonne_prenom
            // 
            this.tbx_ajoutPersonne_prenom.Location = new System.Drawing.Point(228, 209);
            this.tbx_ajoutPersonne_prenom.Name = "tbx_ajoutPersonne_prenom";
            this.tbx_ajoutPersonne_prenom.Size = new System.Drawing.Size(255, 20);
            this.tbx_ajoutPersonne_prenom.TabIndex = 5;
            // 
            // tbx_ajoutPersonne_ville
            // 
            this.tbx_ajoutPersonne_ville.Location = new System.Drawing.Point(228, 265);
            this.tbx_ajoutPersonne_ville.Name = "tbx_ajoutPersonne_ville";
            this.tbx_ajoutPersonne_ville.Size = new System.Drawing.Size(255, 20);
            this.tbx_ajoutPersonne_ville.TabIndex = 6;
            // 
            // btn_ajoutPersonne_fermer
            // 
            this.btn_ajoutPersonne_fermer.Location = new System.Drawing.Point(355, 364);
            this.btn_ajoutPersonne_fermer.Name = "btn_ajoutPersonne_fermer";
            this.btn_ajoutPersonne_fermer.Size = new System.Drawing.Size(115, 35);
            this.btn_ajoutPersonne_fermer.TabIndex = 7;
            this.btn_ajoutPersonne_fermer.Text = "Fermer";
            this.btn_ajoutPersonne_fermer.UseVisualStyleBackColor = true;
            
            // 
            // btn_ajoutPersonne_ajouter
            // 
            this.btn_ajoutPersonne_ajouter.Location = new System.Drawing.Point(476, 364);
            this.btn_ajoutPersonne_ajouter.Name = "btn_ajoutPersonne_ajouter";
            this.btn_ajoutPersonne_ajouter.Size = new System.Drawing.Size(112, 35);
            this.btn_ajoutPersonne_ajouter.TabIndex = 8;
            this.btn_ajoutPersonne_ajouter.Text = "Ajouter";
            this.btn_ajoutPersonne_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajoutPersonne_ajouter.Click += new System.EventHandler(this.btn_ajoutPersonne_ajouter_Click);
            // 
            // FrmAjouterPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(675, 453);
            this.Controls.Add(this.btn_ajoutPersonne_ajouter);
            this.Controls.Add(this.btn_ajoutPersonne_fermer);
            this.Controls.Add(this.tbx_ajoutPersonne_ville);
            this.Controls.Add(this.tbx_ajoutPersonne_prenom);
            this.Controls.Add(this.tbx_ajoutPersonne_nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ajoutPersonne_titre);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmAjouterPersonne";
            this.Text = "Ajouter une personne";
            this.Load += new System.EventHandler(this.FrmAjouterPersonne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ajoutPersonne_titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_ajoutPersonne_nom;
        private System.Windows.Forms.TextBox tbx_ajoutPersonne_prenom;
        private System.Windows.Forms.TextBox tbx_ajoutPersonne_ville;
        private System.Windows.Forms.Button btn_ajoutPersonne_fermer;
        private System.Windows.Forms.Button btn_ajoutPersonne_ajouter;
    }
}