using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesReutilisables.Human {
    /// <summary>
    /// Représente une personne
    /// </summary>
    public abstract class Personne {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Civilite Civilite { get; set; }

        public Personne() {
        }

        public Personne(string nom, string prenom, Civilite civilite = Civilite.Autre) {
            Nom = nom;
            Prenom = prenom;
            Civilite = civilite;
        }

        public override string ToString() {
            string civilite;
            switch (Civilite) {
                case Civilite.Madame:
                    civilite = "Mme ";
                    break;
                case Civilite.Monsieur:
                    civilite = "M. ";
                    break;
                case Civilite.Autre:
                    civilite = "";
                    break;
                default:
                    civilite = "";
                    break;
            }
            return civilite + Nom + " " + Prenom;
        }

        /// <summary>
        /// Permet d'afficher la carte de visite
        /// </summary>
        /// <returns></returns>
        public virtual string CarteDeVisite() { // virtual permet la redéfinition de la méthode dans une classe enfant
            string civilite;
            switch (Civilite) {
                case Civilite.Madame:
                    civilite = "Mme ";
                    break;
                case Civilite.Monsieur:
                    civilite = "M. ";
                    break;
                case Civilite.Autre:
                    civilite = "";
                    break;
                default:
                    civilite = "";
                    break;
            }
            return civilite + Nom + " " + Prenom;
        }
    }
}
