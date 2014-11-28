using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;


namespace Metier
{
    /// <summary>
    /// Classe Angence
    /// </summary>
    [DataContract]
    [Serializable]
    [XmlRoot("Agence", Namespace = "", IsNullable = false)]
    public class Agence
    {
        #region Attributs
        private string nom;
        private List<Voiture> parcVoitures;
        private List<Personne> lesPersonnes;
        #endregion

        #region Getters And Setters
        [DataMember]
        [XmlElement("Nom")]
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        [DataMember]
        [XmlArray("ParcVoiture")]
        [XmlArrayItem("Voiture", typeof(Voiture))]
        public  List<Voiture> ParcVoitures
        {
            get { return parcVoitures; }
            set { parcVoitures = value; }
        }

        [DataMember]
        [XmlArray("LesPersonnes")]
        [XmlArrayItem("Personne", typeof(Personne))]
        public List<Personne> LesPersonnes
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
            voiture.Loueur = personne.Nom;
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
