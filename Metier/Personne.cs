using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

#region Sérialisation

        public void Exporter(List<Personne>mesDonees)
        {
            String cheminComplet = "";
            String nomFichier = "";


                cheminComplet = "M:\\GestionAutomobile";

                FileStream unFlux =null;
                BinaryFormatter fs;

                try
                {
                    Directory.SetCurrentDirectory(cheminComplet);

                    unFlux =new FileStream(nomFichier,FileMode.Create);

                    //On formate le flux en binaire
                    fs =new BinaryFormatter();

                    fs.Serialize(unFlux, mesDonees);
                  
                }

                finally
                {
                    unFlux.Close();
                }
            }
        }



#endregion
    }
}
