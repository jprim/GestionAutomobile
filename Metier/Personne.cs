using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class Personne
    {
        #region Attribut
        private String nom;
        private String prenom;
        private String ville;

        #endregion

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        #region Getters And Setters
        public String Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        #endregion
        #region Constructeurs
        public String Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        /// <summary>
        /// Constructeur vide 
        /// </summary>
        public Personne()
        {

        }
        /// <summary>
        /// Constructeur surchargé
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="ville"></param>
        public Personne(String nom, String prenom, String ville)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.ville = ville;
        }

        #endregion
    }
}
