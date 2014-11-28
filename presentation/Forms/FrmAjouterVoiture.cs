using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace presentation.Forms
{
    public partial class FrmAjouterVoiture : Form
    {
        private Agence uneAgence;
        private Voiture uneVoiture;
        private List<Voiture> lesVoitures;
        public FrmAjouterVoiture( List<Voiture> lesVoit)
        {
            InitializeComponent();
            uneVoiture = new Voiture();
            this.AcceptButton = btn_ajoutVoiture;
            btn_ajoutVoiture.DialogResult = DialogResult.OK;
            btn_ajoutVoiture_fermer.DialogResult = DialogResult.Cancel;
            lesVoitures = lesVoit;


        }

        private void btn_ajoutVoiture_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ajoutVoiture_Click(object sender, EventArgs e)
        {
            string marque = tbx_ajoutVoiture_Marque.Text;
            string immatriculation = tbx_ajoutVoiture_immatriculation.Text;
            string annee = tbx_ajouttbx_ajoutVoiture_annee.Text;

            Voiture voit = new Voiture(marque, immatriculation, annee);
            lesVoitures.Add(voit);
            ;

        }
    }
}
