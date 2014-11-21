namespace presentation.Forms
{
    partial class FrmSupprimerPersonne
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
            this.btn_SupprPers_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SupprPers_Close
            // 
            this.btn_SupprPers_Close.Location = new System.Drawing.Point(101, 190);
            this.btn_SupprPers_Close.Name = "btn_SupprPers_Close";
            this.btn_SupprPers_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_SupprPers_Close.TabIndex = 0;
            this.btn_SupprPers_Close.Text = "Fermer";
            this.btn_SupprPers_Close.UseVisualStyleBackColor = true;
            this.btn_SupprPers_Close.Click += new System.EventHandler(this.btn_SupprPers_Close_Click);
            // 
            // FrmSupprimerPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_SupprPers_Close);
            this.Name = "FrmSupprimerPersonne";
            this.Text = "FrmSupprimerPersonne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SupprPers_Close;
    }
}