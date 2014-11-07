using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    /// <summary>
    /// Classe Voiture
    /// </summary>
    class Voiture
    {
        #region Attributs
        private string categorie;    

        private string dateMiseService;

        private bool estLouee;

        private string immatriculation;

        private string loueur;

        private string nom;

        private int puissance;

        #endregion
        #region Getters And Setters

        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }

        public string DateMiseService
        {
            get { return dateMiseService; }
            set { dateMiseService = value; }
        }
        

        public bool EstLouee
        {
            get { return estLouee; }
            set { estLouee = value; }
        }
        

        public string Immatriculation
        {
            get { return immatriculation; }
            set { immatriculation = value; }
        }
       

        public string Loueur
        {
            get { return loueur; }
            set { loueur = value; }
        }
        

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
       

        public int Puissance
        {
            get { return puissance; }
            set { puissance = value; }
        }

        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public void Voiture()
        {

        }

        /// <summary>
        ///  Constructeur surchargé (voiture louée)
        /// </summary>
        /// <param name="uneCate"></param>
        /// <param name="uneDate"></param>
        /// <param name="louee"></param>
        /// <param name="immat"></param>
        /// <param name="loueur"></param>
        /// <param name="nom"></param>
        /// <param name="puissance"></param>
        public void Voiture(string uneCate, string uneDate, bool louee, string immat, string loueur, string nom, int puissance)

        {
            this.categorie = uneCate;
            this.dateMiseService = uneDate;
            this.estLouee = louee;
            this.immatriculation = immat;
            this.loueur = loueur;
            this.nom = nom;
            this.puissance = puissance;

        }

        /// <summary>
        /// Constructeur surchargé (voiture non louée)
        /// </summary>
        /// <param name="uneCate"></param>
        /// <param name="uneDate"></param>
        /// <param name="louee"></param>
        /// <param name="immat"></param>
        /// <param name="puissance"></param>
        public void Voiture(string uneCate, string uneDate, bool louee, string immat, int puissance)
        {
            this.categorie = uneCate;
            this.dateMiseService = uneDate;
            this.estLouee = louee;
            this.immatriculation = immat;
            this.puissance = puissance;

        }

        #endregion

    }
}
