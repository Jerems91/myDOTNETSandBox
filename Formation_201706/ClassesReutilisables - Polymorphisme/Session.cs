using ClassesReutilisables.Human;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesReutilisables {
    /// <summary>
    /// Représente une session
    /// </summary>
    public class Session {
        private int nbPlacesMaxi;
        private int nbInscrits = 0;
        private Stagiaire[] stagiaires;

        public DateTime DateDebut { get; set; }
        public string Lieu { get; set; }
        public Formation Formation { get; set; }
        public int NbPlacesMaxi {
            get => nbPlacesMaxi;
            set {
                nbPlacesMaxi = value;
                //Stagiaire[] oldStagiaires = stagiaires;
                //stagiaires = new Stagiaire[nbPlacesMaxi];
                //for (int i = 0; i < stagiaires.Length; i++) {
                //    if (i < oldStagiaires.Length) {
                //        stagiaires[i] = oldStagiaires[i];
                //    } else {
                //        break;
                //    }
                //}
                if (stagiaires == null) {
                    stagiaires = new Stagiaire[value];
                } else {
                    Array.Resize(ref stagiaires, value);
                }
            }
        }
        public Formateur Formateur { get; set; }
        public Stagiaire[] Stagiaires { get; set; }
        public int NbInscrits { get; private set; }

        // Valeur par défaut pour nbPlacesMaxi implique que le paramètre devient optionnel
        public Session(DateTime dateDebut, string lieu, Formation formation, int nbPlacesMaxi = 8) {
            DateDebut = dateDebut;
            Lieu = lieu;
            Formation = formation;
            //this.nbPlacesMaxi = nbPlacesMaxi;
            //this.stagiaires = new Stagiaire[nbPlacesMaxi];
            NbPlacesMaxi = nbPlacesMaxi; // Utilisation de la propriété déclenche le traitement du set qui gère le dimensionnement du tableau
        }

        /// <summary>
        /// Permet d'inscrire un stagiaire
        /// </summary>
        /// <param name="s"></param>
        public bool Inscrire(Stagiaire s) {
            if (nbInscrits < stagiaires.Length) {
                if (s.AjouterSession(this)) {
                    stagiaires[nbInscrits++] = s;
                    return true;
                }
            }
            return false;
        }
    }
}
