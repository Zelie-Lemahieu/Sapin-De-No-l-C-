using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialisation des variables:
            int nombreDEtages = 0;
            int nombreDEtoilesParLigne = 0;
            int nombreDEspaceParCote = 0;
            Random aleatoire = new Random();
            int nombreAleatoire = 0;
            int limiteurDeBoules = 0;
            
            //Demande du nombre d'étage à l'utilisateur:
            Console.Write("Entrer un nombre d'étages au sapin : ");
            nombreDEtages = int.Parse(Console.ReadLine());
            Console.Clear();

            //Dessin du sapin:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < nombreDEtages; i++)
            {
                //Dessin des espaces:
                nombreDEspaceParCote = ((2 * nombreDEtages) - (2 * i))/2;
                for (int j = 0; j < nombreDEspaceParCote; j++)
                {
                    Console.Write(' ');
                };

                //Dessin des étoiles et des boules:
                nombreDEtoilesParLigne = (2 * i) - 1;
                for(int j = 0; j < nombreDEtoilesParLigne; j++)
                {
                    nombreAleatoire = aleatoire.Next(1, 101);
                    if (nombreAleatoire <= 15 && limiteurDeBoules <= 0 || limiteurDeBoules <= -5) //<--15% de chance d'afficher une boule au lieu d'une étoile
                    {
                        nombreAleatoire = aleatoire.Next(1, 4);
                        if(nombreAleatoire == 1)//<--Couleur aléatoire parmi 4 possibilités.
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        } 
                        else if (nombreAleatoire == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        } 
                        else if (nombreAleatoire == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        } else
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        };
                        Console.Write('@');
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        limiteurDeBoules = 5;
                    }
                    else
                    {
                        limiteurDeBoules--;
                        Console.Write('*');
                    };
                };
                Console.Write("\n");
            };

            //Dessin du tronc:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i < nombreDEtages - 1 - (nombreDEtages % 3) - ((nombreDEtages - (nombreDEtages % 3)) / 3); i++)
            {
                Console.Write(' ');
            };
            
            for (int i = 0; i < (2 * nombreDEtages + 1) - (2 * (nombreDEtages - 1 - (nombreDEtages % 3) - ((nombreDEtages - (nombreDEtages % 3)) / 3))) - 2; i++)
            {
                Console.Write('M');
            };
            Console.ResetColor();

        }
    }
}