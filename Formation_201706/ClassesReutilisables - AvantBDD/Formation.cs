using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesReutilisables {
    /// <summary>
    /// Représente une formation
    /// </summary>
    public class Formation : IFacturable {
        public string Titre { get; set; }
        public int Duree { get; set; }
        public double PrixHt { get; set; }

        public Formation(string titre) {
            Titre = titre;
        }

        public double CalculerMontantTtc() {
            return PrixHt * (1 + Utils.TAUX_TVA);
        }
    }
}
