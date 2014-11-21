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

        private void importerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //On affiche une fenêtre permettant de choisir un fichier à charger
            OpenFileDialog FileDialogBin = new OpenFileDialog();
            FileDialogBin.Title = "Choisissez un fichier";
            //On fixe l'extension à .ci
            FileDialogBin.Filter = "Fichiers CI (*.ci)|*.ci";
            DialogResult result = FileDialogBin.ShowDialog();

            //Si l'utilisateur clique sur "Charger"
            if (result == DialogResult.OK)
            {
                String cheminComplet = "";
                String monFichier = "";
                String chemin = "";

                //on récupère le chemin complet, le nom du fichier et le chemin du dossier contenant le fichier a charger
                cheminComplet = FileDialogBin.FileName;
                cheminComplet = cheminComplet.Replace("\\", "\\\\");

                //On récupère le nom du fichier qui se trouve en fin du chemin complet
                monFichier = cheminComplet.Substring(cheminComplet.LastIndexOf("\\\\") + 2, cheminComplet.Length - cheminComplet.LastIndexOf("\\\\") - 2);

                //On récupère le chemin du dossier qui contient le fichier ci-dessus (l'autre partie du chemin complet)
                chemin = cheminComplet.Substring(0, cheminComplet.Length - (nomFichier.Length + 2));

                FileStream unFlux = null;
                BinaryFormatter fs;

                try
                {
                    //On ouvre un flux binaire
                    Directory.SetCurrentDirectory(chemin);
                    unFlux = new FileStream(nomFichier, FileMode.Open);
                    //On formate leflux en binaire
                    fs = new BinaryFormatter();
                    //On vide la collection avant de récupérer le contenu désérialiser

                    uneAgence = (Agence)fs.Deserialize(unFlux);
                    //On affiche un message indiquant le succès de la désérialisation
                    MessageBox.Show("La désérialisation s'est terminée avec succès !", "Désérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    unFlux.Close();
                }
            }
        }

        private void exporterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
