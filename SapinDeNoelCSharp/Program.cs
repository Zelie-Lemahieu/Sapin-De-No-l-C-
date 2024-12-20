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

            //Demande du nombre d'étage à l'utilisateur:
            Console.Write("Entrer un nombre d'étages au sapin : ");
            nombreDEtages = int.Parse(Console.ReadLine());
            Console.Clear();

            //Dessin des étoiles
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < nombreDEtages; i++)
            {
                nombreDEspaceParCote = ((2 * nombreDEtages) - (2 * i))/2;
                for (int j = 0; j < nombreDEspaceParCote; j++)
                {
                    Console.Write(' ');
                };
                nombreDEtoilesParLigne = (2 * i) - 1;
                for(int j = 0; j < nombreDEtoilesParLigne; j++)
                {
                    Console.Write('*');
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
                Console.Write('H');
            };
            Console.ResetColor();

        }
    }
}