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
    public partial class FrmAjouterPersonne : Form
    {

        private Personne unePersonne;
        private List<Personne> lesPersonnes;
        public FrmAjouterPersonne(List<Personne> lesPers)
        {
            InitializeComponent();
            unePersonne=new Personne();

            // Actions des boutons
            this.AcceptButton = btn_ajoutPersonne_ajouter;
            btn_ajoutPersonne_ajouter.DialogResult = DialogResult.OK;
            btn_ajoutPersonne_fermer.DialogResult = DialogResult.Cancel;
            lesPersonnes = lesPers;

        }

        private void FrmAjouterPersonne_Load(object sender, EventArgs e)
        {

        }

        private void btn_ajoutPersonne_ajouter_Click(object sender, EventArgs e)
        {
            string nom = tbx_ajoutPersonne_nom.Text;
            string prenom = tbx_ajoutPersonne_prenom.Text;
            string ville = tbx_ajoutPersonne_ville.Text;
            Personne pers = new Personne(nom, prenom, ville);
            lesPersonnes.Add(pers);
            
        }
    }
}
