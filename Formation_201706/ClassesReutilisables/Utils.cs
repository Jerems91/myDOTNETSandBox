using ClassesReutilisables.Human;
using System.Collections.Generic;
using System.IO;
using System;

namespace ClassesReutilisables {
    /// <summary>
    /// Représente la liste des civilités
    /// </summary>
    public enum Civilite {
        Madame,
        Monsieur,
        Autre
    }

    public class Utils {
        public const double TAUX_TVA = 0.2;
        public const string FILENAME = @"C:/formation/csharp/stagiaires.csv";

        public static double CalculerMontantApresRemise(double montant, IRemisable ir) {
            return montant * (1 - ir.CalculerRemise());
        }

        public static void Save(ICollection<Stagiaire> stagiaires) {
            FileStream fs = new FileStream(FILENAME, FileMode.Create);
            Save(stagiaires, fs);
        }

        public static void Save(ICollection<Stagiaire> stagiaires, Stream stream) {
            using (StreamWriter sw = new StreamWriter(stream)) {
                foreach (Stagiaire s in stagiaires) {
                    sw.WriteLine(CsvHelper.ToCsv(s));
                }
            }
        }
    }
}