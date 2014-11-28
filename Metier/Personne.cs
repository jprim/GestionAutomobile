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
    public class Personne
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


        public void Exporter(List<Personne> mesDonnees)
        {
            String cheminComplet = "";
            String nomFichier = "Base.ci";


            cheminComplet = Environment.CurrentDirectory;

            FileStream unFlux = null;
            BinaryFormatter fs;


            Directory.SetCurrentDirectory(cheminComplet);

            unFlux = new FileStream(nomFichier, FileMode.Create);

            //On formate le flux en binaire
            fs = new BinaryFormatter();

            fs.Serialize(unFlux, mesDonnees);


            unFlux.Close();

        }

        public List<Personne> Importer()
        {
            List<Personne> mesDonnees = null;
            String cheminComplet = "";
            String nomFichier = "Base.ci";

            //On récupère le chemin complet, le nom du fichier et le chemin du dossier contenant le fichier à charger
            cheminComplet = Environment.CurrentDirectory;
            FileStream unFlux = null;
            BinaryFormatter fs;

            //On ouvre  un flux binaire
            Directory.SetCurrentDirectory(cheminComplet);
            unFlux = new FileStream(nomFichier, FileMode.Open);
            //On formate le flux en binaire
            fs = new BinaryFormatter();
            //On vide la collection avant de récupérer le contenu désérialiser
            //unePersonne.Clear();
            mesDonnees = (List<Personne>)fs.Deserialize(unFlux);

            unFlux.Close();
            return mesDonnees;
        }
    }

}

