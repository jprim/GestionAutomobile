using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Metier
{
    [DataContract]
    [Serializable]
    [XmlRoot("Personne", Namespace = "", IsNullable = false)]
    class Personne
    {
        #region Attribut
        private String nom;
        private String prenom;
        private String ville;

        #endregion
        #region Getters And Setters
        [DataMember]
        [XmlElement("Nom")]
        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        [DataMember]
        [XmlElement("Prenom")]
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
