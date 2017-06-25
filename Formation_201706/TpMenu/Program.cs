using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpMenu {
    class Program {
        static void Main(string[] args) {

            Console.Title = "TP Menu";
            string saisie;
            int[] monTableau = null;

            do {
                Console.Clear();
                Console.WriteLine("*** Gestion de tableau ***");
                Console.WriteLine("1) Saisie du tableau");
                Console.WriteLine("2) Affichage du tableau");
                Console.WriteLine("3) Valeurs caractéristiques (min, max, moyenne)");
                Console.WriteLine("4) Option 4");
                Console.WriteLine("9) Quitter");
                Console.Write("Choix : ");

                saisie = Console.ReadLine();

                switch (saisie) {
                    case "1":
                        monTableau = SaisirTableau();
                        Console.ReadLine();
                        break;
                    case "2":
                        AfficherDonnees(monTableau);
                        Console.ReadLine();
                        break;
                    case "3":
                        AfficherCaracteristiques(monTableau);
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Option " + saisie + " valide");
                        Console.ReadLine();
                        break;
                    case "9":
                        Console.WriteLine("Sortie de l'application...");
                        break;
                    default:
                        Console.WriteLine("Option " + saisie + " invalide");
                        Console.ReadLine();
                        break;
                }

            } while (saisie != "9");
        }

        /// <summary>
        /// Permet de saisir un tableau et de le renvoyer
        /// </summary>
        /// <returns></returns>
        private static int[] SaisirTableau() {
            Console.Write("Taille du tableau : ");
            string saisieTaille = Console.ReadLine();
            int taille = Convert.ToInt32(saisieTaille);
            int[] monTableau = new int[taille];
            for (int i = 0; i < taille; i++) {
                Console.Write("Valeur " + i + " : ");
                string saisieValue = Console.ReadLine();
                monTableau[i] = Convert.ToInt32(saisieValue);
            }
            return monTableau;
        }

        /// <summary>
        /// Permet d'afficher le tableau
        /// </summary>
        /// <param name="monTableau"></param>
        private static void AfficherDonnees(int[] monTableau) {
            if (monTableau != null) {
                Console.WriteLine("Contenu du tableau :");
                for (int i = 0; i < monTableau.Length; i++) {
                    AfficherDonnees(monTableau, i);
                }
            } else {
                Console.WriteLine("Le tableau n'est pas rempli");
            }
        }

        /// <summary>
        /// Permet d'afficher un élément du tableau
        /// </summary>
        /// <param name="monTableau"></param>
        /// <param name="indice"></param>
        private static void AfficherDonnees(int[] monTableau, int indice) {
            Console.WriteLine("[" + indice + "] = " + monTableau[indice]);
        }

        /// <summary>
        /// Permet d'afficher les caractéristiques du tableau
        /// </summary>
        /// <param name="monTableau"></param>
        private static void AfficherCaracteristiques(int[] monTableau) {
            if (monTableau != null) {
                Console.WriteLine("Minimum : " + monTableau.Min());
                Console.WriteLine("Maximum : " + monTableau.Max());
                Console.WriteLine("Moyenne : " + monTableau.Average());
                /*int min = monTableau[0];
                int max = monTableau[0];
                int somme = monTableau[0];
                for (int i = 1; i < monTableau.Length; i++) {
                    if (monTableau[i] < min) {
                        min = monTableau[i];
                    }
                    if (monTableau[i] > max) {
                        max = monTableau[i];
                    }
                    somme += monTableau[i];
                }
                double moy = Convert.ToDouble(somme) / Convert.ToDouble(monTableau.Length);
                Console.WriteLine("Minimum : " + min);
                Console.WriteLine("Maximum : " + max);
                Console.WriteLine("Moyenne : " + moy);*/
            } else {
                Console.WriteLine("Le tableau n'est pas rempli");
            }
        }
    }
}
