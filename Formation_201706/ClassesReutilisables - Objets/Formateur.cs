using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesReutilisables {
    /// <summary>
    /// Représente un formateur
    /// </summary>
    public class Formateur {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Civilite Civilite { get; set; }
        public string Matricule { get; set; }
        public bool Interne { get; set; }

        public Formateur() {
        }

        public Formateur(string nom, string prenom) {
            Nom = nom;
            Prenom = prenom;
        }

        public Formateur(string nom, string prenom, Civilite civilite) : this(nom, prenom) {
            Civilite = civilite;
        }
    }
}
