using ClassesReutilisables;
using ClassesReutilisables.Human;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFormationConsole {
    class Program {
        static void Main(string[] args) {
            // Instanciation d'un stagiaire
            Stagiaire s1 = new Stagiaire();
            s1.Nom = "DESSAINT";
            s1.Prenom = "Jérémy";
            s1.Societe = "Groupama";
            s1.Civilite = Civilite.Monsieur;
            s1.Email = "jeremy.dessaint@groupama.com";
            s1.Payeur = Payeur.Societe;

            Console.WriteLine(s1);

            Console.WriteLine("Nombre de stagiaires : " + Stagiaire.nbStagiaires);

            // Instanciation d'un autre stagiaire avec le constructeur nom / prenom / civilité
            Stagiaire s2 = new Stagiaire("DESSAINT", "Voahirana", Civilite.Madame);

            Console.WriteLine(s2);

            Console.WriteLine("Nombre de stagiaires : " + Stagiaire.nbStagiaires);

            // Instanciation d'un autre stagiaire avec le constructeur nom / prenom
            Stagiaire s3 = new Stagiaire("DESSAINT", "Emma");

            Console.WriteLine(s3);

            Console.WriteLine("Nombre de stagiaires : " + Stagiaire.nbStagiaires);

            // Instanciation d'un formateur
            Formateur f1 = new Formateur("MARRON", "Benjamin", Civilite.Monsieur);

            Console.WriteLine(f1);

            object p = new Stagiaire("DUPONT", "Martine", Civilite.Madame);
            Console.WriteLine(p); // Appel au ToString() de Stagiaire via le principe de polymorphisme
            if (p.GetType().Equals(typeof(Stagiaire))) { // Test sur le type réel de l'instance
                Console.WriteLine("Je suis un stagiaire");
                Stagiaire sp = (Stagiaire)p;
                Stagiaire sp2 = p as Stagiaire;
            }

            if (p is Personne) { // Test si on est dans la même chaine d'héritage
                Console.WriteLine("Je suis une personne");
            }

            Console.ReadLine();
        }
    }
}
