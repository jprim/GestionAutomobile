namespace presentation.Forms
{
    partial class FrmSupprimerVoiture
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
            this.btn_SupprVoit_Fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SupprVoit_Fermer
            // 
            this.btn_SupprVoit_Fermer.Location = new System.Drawing.Point(105, 190);
            this.btn_SupprVoit_Fermer.Name = "btn_SupprVoit_Fermer";
            this.btn_SupprVoit_Fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_SupprVoit_Fermer.TabIndex = 0;
            this.btn_SupprVoit_Fermer.Text = "Fermer";
            this.btn_SupprVoit_Fermer.UseVisualStyleBackColor = true;
            this.btn_SupprVoit_Fermer.Click += new System.EventHandler(this.btn_SupprVoit_Fermer_Click);
            // 
            // FrmSupprimerVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_SupprVoit_Fermer);
            this.Name = "FrmSupprimerVoiture";
            this.Text = "FrmSupprimerVoiture";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SupprVoit_Fermer;
    }
}