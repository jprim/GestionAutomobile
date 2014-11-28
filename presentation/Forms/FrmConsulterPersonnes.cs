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
    public partial class FrmConsulterPersonnes : Form
    {
        private List<Personne> lesPersonnes;

        public List<Personne> LesPersonnes
        {
            get { return lesPersonnes; }
            set { lesPersonnes = value; }
        }
        public FrmConsulterPersonnes()
        {
            InitializeComponent();
        }

        public FrmConsulterPersonnes(List<Personne> mesPersonnes)
        {
            InitializeComponent();
            lesPersonnes = mesPersonnes;
        }

        void initialise()
        {

            dgv_affichagePersonnes.RowHeadersWidth += 95;
            dgv_affichagePersonnes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            // On définit la taille

            //définits le nombre de colonne 
            dgv_affichagePersonnes.ColumnCount = 3;

            //list<String> =Collection de chaine
            //Création des textes d'en-tête des lignes du DatagridView
            //nomsHeadersCell = en-tête de colonne 
            //Déclaration et instanciation d'une collection de type collection de chaine nommé
            //nomsHeadresCell   
            List<String> nomsHeaderCell = new List<String>();
            //Ajout d'un objet de type chaîne à la collection nomsHeadresCell 
            nomsHeaderCell.Add("Numéro");
            nomsHeaderCell.Add("Nom");
            nomsHeaderCell.Add("Ville");
            //Appel de la méthode CreerDgv en lui passant comme paramêtre nomsHeadresCell 
            CreerDgv(nomsHeaderCell);

        }

        private void CreerDgv(List<string> nomsHeaderCell)
        {
            //Initialise les en-tête des colonnes

            int nbColonne = 3; 
            for (int i = 0; i < nbColonne; i++)
            {

                DataGridViewColumn colonne = dgv_affichagePersonnes.Columns[i];
               
                colonne.HeaderCell.Value = nomsHeaderCell[i];
                
            }

            
            for (int i = 0; i < lesPersonnes.Count; i++)
            {
               
                dgv_affichagePersonnes.Rows.Add();
                dgv_affichagePersonnes.Rows[i].HeaderCell.Value = "Personne";
            }

            EcritureCellules();
        }

        void EcritureCellules()
        {
            int i = 0;
                        
            foreach (Personne unePers in lesPersonnes)
            {
                dgv_affichagePersonnes.Rows[i].Cells[0].Value = unePers.Nom;
                dgv_affichagePersonnes.Rows[i].Cells[1].Value = unePers.Prenom;
                dgv_affichagePersonnes.Rows[i].Cells[2].Value = unePers.Ville;

                i++;

            }
        }
        private void btn_affichePersonnes_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_visualiser_personne_Click(object sender, EventArgs e)
        {
            initialise();
            EcritureCellules();
        }

       
    }
}
