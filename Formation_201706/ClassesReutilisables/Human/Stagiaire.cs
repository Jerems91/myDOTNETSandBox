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
    public class Stagiaire : Personne, IRemisable {
        public static int nbStagiaires = 0;

        private int nbSessionsMaxi = 10;
        private double remise = 0;

        public string Societe { get; set; }
        public string Email { get; set; }
        public Payeur Payeur { get; set; }
        public HashSet<Session> Sessions { get; set; }
        public int NbSessionsMaxi { get => nbSessionsMaxi; private set => nbSessionsMaxi = value; }
        public int NbSessions { get => Sessions.Count; }
        public bool RegimeAlimentaire { get; set; }
        public double Remise { set => remise = value; }

        public Stagiaire() {
            Sessions = new HashSet<Session>();
        }

        public Stagiaire(string nom, string prenom) : base(nom, prenom) {
            Sessions = new HashSet<Session>();
            nbStagiaires++;
        }

        public Stagiaire(string nom, string prenom, Civilite civilite) : base(nom, prenom, civilite) {
            Sessions = new HashSet<Session>();
            nbStagiaires++;
        }

        /// <summary>
        /// Permet de s'inscrire à une session
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool AjouterSession(Session s) {
            if (Sessions.Count < NbSessionsMaxi) {
                Sessions.Add(s);
                return true;
            }
            return false;
        }

        public override string ToString() {
            return (Societe != null) ? base.ToString() + " (" + Societe + ")" : base.ToString();
        }

        public double CalculerRemise() {
            double result = 0;
            switch (Payeur) {
                case Payeur.PoleEmploi:
                    result = 0.35;
                    break;
                case Payeur.Societe:
                    break;
                case Payeur.Individuel:
                    break;
                case Payeur.OPCA:
                    break;
                case Payeur.Fongecif:
                    break;
                default:
                    result = 0;
                    break;
            }
            return Math.Max(result,remise);
        }
    }
}
