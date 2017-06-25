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
    public class Session : IFacturable, IRemisable {
        private double remise = 0;

        public DateTime DateDebut { get; set; }
        public string Lieu { get; set; }
        public Formation Formation { get; set; }
        public int NbPlacesMaxi { get; set; }
        public Formateur Formateur { get; set; }
        public List<Stagiaire> Stagiaires { get; set; }
        public int NbInscrits { get => Stagiaires.Count; }
        public double Remise { set => remise = value; }
        public bool IsFull { get => (NbInscrits >= NbPlacesMaxi); }

        // Valeur par défaut pour nbPlacesMaxi implique que le paramètre devient optionnel
        public Session(DateTime dateDebut, string lieu, Formation formation, int nbPlacesMaxi = 8) {
            DateDebut = dateDebut;
            Lieu = lieu;
            Formation = formation;
            NbPlacesMaxi = nbPlacesMaxi;
            Stagiaires = new List<Stagiaire>();
        }

        /// <summary>
        /// Permet d'inscrire un stagiaire
        /// </summary>
        /// <param name="s"></param>
        public bool Inscrire(Stagiaire s) {
            if (Stagiaires.Count < NbPlacesMaxi) {
                if (s.AjouterSession(this)) {
                    Stagiaires.Add(s);
                    return true;
                }
            }
            return false;
        }

        public double CalculerMontantTtc() {
            double montantSession = 0;
            double montantFormation = Formation.CalculerMontantTtc();
            foreach (var s in Stagiaires) {
                montantSession += Utils.CalculerMontantApresRemise(montantFormation, s);
            }
            return Utils.CalculerMontantApresRemise(montantSession, this);
        }

        public double CalculerRemise() {
            double result = 0;
            if (Stagiaires.Count > 2) {
                string societe = Stagiaires[0].Societe;
                if (societe != null && Stagiaires.All(s => s.Societe.Equals(societe))) {
                    result = 0.15;
                }
            }
            return Math.Max(result, remise);
        }
    }
}
