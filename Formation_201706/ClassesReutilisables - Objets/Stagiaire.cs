using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesReutilisables {
    /// <summary>
    /// Représente la liste des payeurs
    /// </summary>
    public enum Payeur {
        PoleEmploi,
        Societe,
        Individuel,
        OPCA,
        Fongecif
    }

    /// <summary>
    /// Représente un stagiaire
    /// </summary>
    public class Stagiaire {
        public static int nbStagiaires = 0;

        private int nbSessions = 0;
        private int nbSessionsMaxi = 10;

        public string Nom { get ; set ; }
        public string Prenom { get; set; }
        public Civilite Civilite { get; set; }
        public string Societe { get; set; }
        public string Email { get; set; }
        public Payeur Payeur { get; set; }
        public Session[] Sessions { get; set; }
        public int NbSessions { get ; }
        public int NbSessionsMaxi { get ; }

        public Stagiaire() {

        }

        public Stagiaire(string nom, string prenom) {
            Nom = nom;
            Prenom = prenom;
            Sessions = new Session[nbSessionsMaxi];
            nbStagiaires++;
        }

        public Stagiaire(string nom, string prenom, Civilite civilite) : this(nom, prenom) {
            Civilite = civilite;
        }

        /// <summary>
        /// Permet de s'inscrire à une session
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool AjouterSession(Session s) {
            if (nbSessions < Sessions.Length) {
                Sessions[nbSessions++] = s;
                return true;
            }
            return false;
        }
    }
}
