namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */


        Console.WriteLine("§§§ CHASSE AU CERF §§§");
        Console.WriteLine("Arthur : Allons chasser ce cerf !");

        // Déclaration des variables
        int fleches = 5;
        int tirsReussis = 0;
        string resultat = "";

        // Boucle de la chasse
        while (fleches > 0 && tirsReussis < 3)
        {
            Console.WriteLine("\nFlèches restantes : " + fleches);

            Console.WriteLine("Résultat du tir :");
            Console.WriteLine("1 - Touché");
            Console.WriteLine("2 - Raté");

            resultat = Console.ReadLine();

            if (resultat == "1")
            {
                fleches--;
                tirsReussis++;

                Console.WriteLine("Bien joué ! Le cerf est touché.");
            }
            else if (resultat == "2")
            {
                fleches--;

                Console.WriteLine("Raté ! Le cerf s'est échappé de justesse.");
            }
            else
            {
                Console.WriteLine("Saisie invalide ! Choisissez 1 ou 2.");
            }
        }

        // Bilan final
        Console.WriteLine("\n===== BILAN DE LA CHASSE =====");

        Console.WriteLine("Tirs réussis : " + tirsReussis);
        Console.WriteLine("Flèches restantes : " + fleches);

        if (tirsReussis == 3)
        {
            Console.WriteLine("Le cerf est abattu !");
            Console.WriteLine("Résultat : Chasse réussie !");
        }
        else
        {
            Console.WriteLine("Le cerf s'est échappé !");
            Console.WriteLine("Résultat : Chasse échouée !");
        }
    }
}




    