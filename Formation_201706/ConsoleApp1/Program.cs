using System;

namespace ConsoleApp1 {
    /// <summary>
    /// Représente le programme principal de l'application
    /// </summary>
    class Program {

        /// <summary>
        /// Représente l'énumération des saisons
        /// </summary>
        enum Saison {
            HIVER,
            PRINTEMPS,
            ETE,
            AUTOMNE
        }

        /// <summary>
        /// Représente les options disponibles pour un véhicule
        /// </summary>
        [Flags] // Indique qu'il faut utiliser les libellés lors de la restitution
        /* On affecte des puissances de 2 pour les valeurs numériques afin d'avoir
         * des valeurs uniques pour les combinaisons et éviter de tomber sur une 
         * autre valeur de l'énumération
        */
        enum Options {
            TOIT_OUVRANT = 1,
            GPS = 2,
            CLIMATISATION = 4,
            DIRECTION_ASSISTEE = 8,
            JANTES_ALU = 16,
            ATTELAGE = 32,
            PEINTURE_METALLISEE = 64
        }

        /// <summary>
        /// Représente un véhicule
        /// </summary>
        // ATTENTION struct est un type valeur
        struct Automobile {
            public string marque;
            public string modele;
            public int puissance;
            public string couleur;
            public Options caracteristiques;
        }

        static void Main(string[] args) {
            Console.WriteLine("Hello World !!!");

            //Déclaration de variables
            int monEntier;
            monEntier = 17;
            Console.WriteLine(monEntier);

            string maChaine = "Ceci est une chaîne de caractères";
            Console.WriteLine(maChaine);

            double monDouble = 12.5;
            Console.WriteLine(monDouble);

            float monFloat = 25.54F;
            Console.WriteLine(monFloat);

            const string maConstante = "Ceci est une constante";
            // maConstante = "nouvelle chaine"; => erreur de compilation car on ne peut pas changer la valeur de la constante
            Console.WriteLine(maConstante);

            var maVariable = 2; // Le type est déterminé lors de l'affectation
            // maVariable = "test"; => erreur de compilation car la première affectation a fixé le type sur int
            Console.WriteLine(maVariable);

            char monCaractère = 'c'; // ATTENTION : simple cote pour un caractère
            Console.WriteLine(monCaractère);

            // Définition de la saison actuelle
            Saison maintenant = Saison.ETE;
            Console.WriteLine(maintenant);

            // Définition de la liste des options du véhicule
            Options mesOptions = Options.GPS | Options.CLIMATISATION; // ATTENTION : | est un OU binaire => mesOptions a le résultat de l'opération
            Console.WriteLine(mesOptions);

            // Définition d'un véhicule
            Automobile monVehicule;
            monVehicule.marque = "Opel";
            monVehicule.modele = "Zafira";
            monVehicule.puissance = 115;
            monVehicule.couleur = "Gris métallisé";
            monVehicule.caracteristiques = Options.CLIMATISATION | Options.DIRECTION_ASSISTEE | Options.JANTES_ALU | Options.PEINTURE_METALLISEE;
            Console.WriteLine(monVehicule.marque);
            Console.WriteLine(monVehicule.modele);
            Console.WriteLine(monVehicule.puissance);
            Console.WriteLine(monVehicule.couleur);
            Console.WriteLine(monVehicule.caracteristiques);

            // Variable nullable
            int? entierNull = null;
            Console.WriteLine(entierNull);

            // Manipulation des variables
            int compteur = 5;
            Console.WriteLine(compteur); // 5
            compteur = compteur << 2; // Décalage binaire vers la gauche
            Console.WriteLine(compteur); // 20
            compteur >>= 2; // Décalage binaire vers la droite
            Console.WriteLine(compteur); // 5
            compteur += 1;
            Console.WriteLine(compteur); // 6
            compteur++;
            Console.WriteLine(compteur); // 7
            Console.WriteLine(compteur++); // 7
            Console.WriteLine(compteur); // 8
            Console.WriteLine(++compteur); // 9

            // Cast => pas de calcul d'arrondi
            monDouble = 12.5;
            compteur = (int)monDouble;
            Console.WriteLine(compteur); // 12
            monDouble = 12.1;
            compteur = (int)monDouble;
            Console.WriteLine(compteur); // 12
            monDouble = 12.9;
            compteur = (int)monDouble;
            Console.WriteLine(compteur); // 12

            // Convert => calcul d'arrondi mais attention aux règles de conversion
            monDouble = 12.5;
            compteur = Convert.ToInt32(monDouble);
            Console.WriteLine(compteur); // 12
            monDouble = 11.5;
            compteur = Convert.ToInt32(monDouble);
            Console.WriteLine(compteur); // 12 => ATTENTION : si on est pile au milieu, Convert prend le nombre pair
            monDouble = 12.1;
            compteur = Convert.ToInt32(monDouble);
            Console.WriteLine(compteur); // 12
            monDouble = 12.9;
            compteur = Convert.ToInt32(monDouble);
            Console.WriteLine(compteur); // 13

            monDouble = compteur; // Pas besoin de cast explicite

            short monShort;
            long monLong = 999999999999999;
            monShort = (short)monLong; // ATTENTION : lors du cast, un découpage bête est méchant est effectué sur la représentation binaire
            Console.WriteLine(monShort);

            Console.WriteLine("--- Fin du programme ---");

            Console.ReadLine();
        }
    }
}
