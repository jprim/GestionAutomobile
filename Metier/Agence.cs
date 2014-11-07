using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    /// <summary>
    /// Classe Angence
    /// </summary>
    class Agence
    {
        #region Attributs
        private string nom;


        private List<Voiture> parcVoitures;


        private List<Personne> lesPersonnes;

       
        #endregion

        #region Getters And Setters
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        internal List<Voiture> ParcVoitures
        {
            get { return parcVoitures; }
            set { parcVoitures = value; }
        }

        internal List<Personne> LesPersonnes
        {
            get { return lesPersonnes; }
            set { lesPersonnes = value; }
        }

        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur Agence
        /// </summary>
        /// <param name="nom">Le nom de l'agence</param>
        public Agence(string nom)
        {
            this.nom = nom;
            parcVoitures = new List<Voiture>();
            lesPersonnes = new List<Personne>();
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Agence() : this("Nom par default")
        {

        }
        #endregion

        #region Méthodes public
        /// <summary>
        /// Ajoute une voiture à l'agence
        /// </summary>
        /// <param name="voiture">La voiture</param>
        public void AjouterVoiture(Voiture voiture)
        {
            parcVoitures.Add(voiture);
        }
        /// <summary>
        /// Ajoute une personne à l'agence
        /// </summary>
        /// <param name="personne">La personne</param>
        public void AjouterPersonne(Personne personne)
        {
            lesPersonnes.Add(personne);
        }
        /// <summary>
        /// Loue une voiture
        /// </summary>
        /// <param name="voiture">La voiture à louée</param>
        /// <param name="personne">La personne qui loue la voiture</param>
        public void LouerVoiture(Voiture voiture, Personne personne)
        {
            voiture.Loueur = personne;
            voiture.EstLouee = true;
        }
        /// <summary>
        /// Rend une voiture
        /// </summary>
        /// <param name="voiture">La voiture rendue</param>
        public void RendreVoiture(Voiture voiture)
        {
            voiture.Loueur = null;
            voiture.EstLouee = false;
        }

        #endregion

    }
}
