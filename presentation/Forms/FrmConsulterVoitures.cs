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
    public partial class FrmConsulterVoitures : Form
    {
        private List<Voiture> lesVoitures;

        public List<Voiture> LesVoitures
        {
            get { return lesVoitures; }
            set { lesVoitures = value; }
        }

        public FrmConsulterVoitures()
        {
            InitializeComponent();
        }

        public FrmConsulterVoitures(List<Voiture> mesVoitures)
        {
            InitializeComponent();
            this.lesVoitures = mesVoitures;
        }

        void initialise()
        {

            dgv_affichageVoiture.RowHeadersWidth += 95;
            dgv_affichageVoiture.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dgv_affichageVoiture.ColumnCount = 3;

            List<String> nomsHeaderCell = new List<String>();
            //Ajout d'un objet de type chaîne à la collection nomsHeadresCell 
            nomsHeaderCell.Add("Marque");
            nomsHeaderCell.Add("Immatriculation");
            nomsHeaderCell.Add("Année");
            //Appel de la méthode CreerDgv en lui passant comme paramêtre nomsHeadresCell 
            CreerDgv(nomsHeaderCell);

        }

        private void CreerDgv(List<string> nomsHeaderCell)
        {
            //Initialise les en-tête des colonnes

            int nbColonne = 3;
            for (int i = 0; i < nbColonne; i++)
            {

                DataGridViewColumn colonne = dgv_affichageVoiture.Columns[i];

                colonne.HeaderCell.Value = nomsHeaderCell[i];

            }


            for (int i = 0; i < lesVoitures.Count; i++)
            {

                dgv_affichageVoiture.Rows.Add();
                dgv_affichageVoiture.Rows[i].HeaderCell.Value = "Voiture";
            }

            EcritureCellules();
        }

        void EcritureCellules()
        {
            int i = 0;

            foreach (Voiture uneVoit in lesVoitures)
            {
                dgv_affichageVoiture.Rows[i].Cells[0].Value = uneVoit.Nom;
                dgv_affichageVoiture.Rows[i].Cells[1].Value = uneVoit.Immatriculation;
                dgv_affichageVoiture.Rows[i].Cells[2].Value = uneVoit.Categorie;

                i++;

            }
        }


        private void btn_afficheVoiture_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_visiualiser_voiture_Click(object sender, EventArgs e)
        {
            initialise();
            EcritureCellules();


        }
    }
}
