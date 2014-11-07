using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation.Forms
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajouterUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjouterVoiture ajoutVoiture = new FrmAjouterVoiture();
            ajoutVoiture.ShowDialog();
        }

        private void supprimerUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupprimerVoiture suppVoiture = new FrmSupprimerVoiture();
            suppVoiture.ShowDialog();
        }

        private void ajouterUneVoitureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAjouterPersonne ajoutPersonne = new FrmAjouterPersonne();
            ajoutPersonne.ShowDialog();

        }

        private void supprimerUneVoitureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSupprimerPersonne suppPersonne = new FrmSupprimerPersonne();
            suppPersonne.ShowDialog();
        }

        private void toutesLesVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulterVoitures consultVoiture = new FrmConsulterVoitures();
            consultVoiture.ShowDialog();
        }

        private void toutesLesPersonnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulterPersonnes consultPersonne = new FrmConsulterPersonnes();
            consultPersonne.ShowDialog();
        }

        private void louerUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLouerVoiture louerVoiture = new FrmLouerVoiture();
            louerVoiture.ShowDialog();
        }

        private void rendreUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRendreVoiture rendreVoiture = new FrmRendreVoiture();
            rendreVoiture.ShowDialog();
        }


        
    }
}
