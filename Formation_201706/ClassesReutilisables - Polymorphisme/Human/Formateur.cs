using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesReutilisables.Human {
    /// <summary>
    /// Représente un formateur
    /// </summary>
    public class Formateur : Personne {
        public string Matricule { get; set; }
        public bool Interne { get; set; }

        public Formateur() {
        }

        public Formateur(string nom, string prenom) : base(nom, prenom) {
        }

        public Formateur(string nom, string prenom, Civilite civilite) : base(nom, prenom, civilite) {
        }
    }
}
