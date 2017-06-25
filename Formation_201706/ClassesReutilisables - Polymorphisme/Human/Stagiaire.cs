using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesReutilisables.Human {
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
    public class Stagiaire : Personne {
        public static int nbStagiaires = 0;

        private int nbSessions = 0;
        private Session[] sessions = new Session[10];

        public string Societe { get; set; }
        public string Email { get; set; }
        public Payeur Payeur { get; set; }
        public Session[] Sessions { get; set; }
        public int NbSessions { get; private set; }

        public Stagiaire() {

        }

        public Stagiaire(string nom, string prenom) : base(nom, prenom) {
            nbStagiaires++;
        }

        public Stagiaire(string nom, string prenom, Civilite civilite) : base(nom, prenom, civilite) {
            nbStagiaires++;
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

        public override string ToString() {
            return (Societe != null) ? base.ToString() + " (" + Societe + ")" : base.ToString();
        }

        /// <summary>
        /// Permet d'afficher la carte de visite
        /// </summary>
        /// <returns></returns>
        public override string CarteDeVisite() {
            return base.CarteDeVisite() + " (" + Societe + ")";
        }
    }
}
