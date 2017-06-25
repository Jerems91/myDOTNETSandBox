using ClassesReutilisables.Human;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesReutilisables {
    public class CsvHelper {
        public static string ToCsv(Stagiaire s) {
            return String.Format("{0};{1};{2};{3};{4:d};{5};{6};{7};{8};{9}",
                "STAGIAIRE",
                s.Nom,
                s.Prenom,
                s.Civilite,
                s.DateNaissance,
                s.Payeur,
                s.Societe,
                s.Email,
                s.RegimeAlimentaire,
                s.CalculerRemise());
        }
    }
}
