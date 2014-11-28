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
    /// <summary>
    /// Classe Voiture
    /// </summary>
    [DataContract]
    [Serializable]
    [XmlRoot("Voiture", Namespace = "", IsNullable = false)]
    public class Voiture
    {
        #region Attributs
        private string categorie;    

        private string dateMiseService;

        private bool estLouee;

        private string immatriculation;

        private string loueur;

        private string marque;



        #endregion
        #region Getters And Setters
        [DataMember]
        [XmlElement("Categorie")]
        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
        [DataMember]
        [XmlElement("DateMiseService")]
        public string DateMiseService
        {
            get { return dateMiseService; }
            set { dateMiseService = value; }
        }
        [DataMember]
        [XmlElement("EstLouee")]
        public bool EstLouee
        {
            get { return estLouee; }
            set { estLouee = value; }
        }
        [DataMember]
        [XmlElement("Immatriculation")]
        public string Immatriculation
        {
            get { return immatriculation; }
            set { immatriculation = value; }
        }
        [DataMember]
        [XmlElement("Loueur")]
        public string Loueur
        {
            get { return loueur; }
            set { loueur = value; }
        }
        [DataMember]
        [XmlElement("Nom")]
        public string Nom
        {
            get { return marque; }
            set { marque = value; }
        }
        

        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public  Voiture()
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
        /// <param name="marque"></param>
        /// <param name="puissance"></param>
        public  Voiture(string uneCate, string uneDate, bool louee, string immat, string loueur, string marq)

        {
            this.categorie = uneCate;
            this.dateMiseService = uneDate;
            this.estLouee = louee;
            this.immatriculation = immat;
            this.loueur = loueur;
            this.marque = marq;


        }

        /// <summary>
        /// Constructeur surchargé (voiture non louée)
        /// </summary>
        /// <param name="uneCate"></param>
        /// <param name="uneDate"></param>
        /// <param name="louee"></param>
        /// <param name="immat"></param>
        /// <param name="puissance"></param>
        public  Voiture(string uneCate, string uneDate, string immat)
        {
            this.categorie = uneCate;
            this.dateMiseService = uneDate;
            this.immatriculation = immat;

        }

        #endregion

        public void Exporter(List<Voiture> mesDonnees)
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

        public List<Voiture> Importer()
        {
            List<Voiture> mesDonnees = null;
            String cheminComplet = "";
            String nomFichier = "Base.ci";

            //On récupère le chemin complet, le nom du fichier et le chemin du dossier contenant le fichier à charger
            cheminComplet = Environment.CurrentDirectory;
            FileStream unFlux = null;
            BinaryFormatter fs;

            
            Directory.SetCurrentDirectory(cheminComplet);
            unFlux = new FileStream(nomFichier, FileMode.Open);
            
            fs = new BinaryFormatter();
            
            mesDonnees = (List<Voiture>)fs.Deserialize(unFlux);

            unFlux.Close();
            return mesDonnees;
        }

    }
}
