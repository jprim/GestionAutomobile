using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace presentation.Forms
{
    public partial class FrmAccueil : Form
    {
        private List<Personne> lesPersonnes = new List<Personne>();
        private List<Voiture> lesVoitures = new List<Voiture>();
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
            FrmAjouterVoiture ajoutVoiture = new FrmAjouterVoiture(lesVoitures);
            ajoutVoiture.ShowDialog();
        }

        private void supprimerUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupprimerVoiture suppVoiture = new FrmSupprimerVoiture();
            suppVoiture.ShowDialog();
        }

        private void ajouterUneVoitureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAjouterPersonne ajoutPersonne = new FrmAjouterPersonne(lesPersonnes);
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
            FrmConsulterPersonnes consultPersonne = new FrmConsulterPersonnes(lesPersonnes);
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

        private void importerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personne unePersonne = new Personne();
            lesPersonnes = unePersonne.Importer();
            MessageBox.Show("Lecture Terminée");
        }

        private void exporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personne unePersonne = new Personne();
            unePersonne.Exporter(lesPersonnes);
            MessageBox.Show("Sauvegarde Terminée");
        }
    }
}
