using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Réalisation de trois calculs mathématiques
        /// </summary>
        /// <param name="args"></param>
       

        
        static void Main(string[] args)
        {
            int choix = 1;
            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());
                if (choix == 0) 
                { 
                    Environment.Exit(0); 
                }
                if (choix == 1)
                {
                    Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                    int total = int.Parse(Console.ReadLine()); // saisir le nombre
                                                           // calcul de r
                    long resultat = 1;
                    for (int k = 1; k <= total; k++)
                    {
                        resultat *= k;
                    }
                    Console.WriteLine(total + "! = " + resultat);
                }
                else
                {
                    if (choix == 2)
                    {
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int total = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int nbrssensemble = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de r
                        long resultat = 1;
                        for (int k = (total - nbrssensemble + 1); k <= total; k++)
                        {
                            resultat *= k;
                        }
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + total + "/" + nbrssensemble + ") = " + resultat);
                    }
                    else
                    {
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int total = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int nbrssensemble = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de r1
                        long resultat1 = 1;
                        for (int k = (total - nbrssensemble + 1); k <= total; k++)
                        {
                            resultat1 *= k;
                        }
                        // calcul de r2
                        long resultat2 = 1;
                        for (int k = 1; k <= nbrssensemble; k++)
                        {
                            resultat2 *= k;
                        }
                        // calcul de r3
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + total + "/" + nbrssensemble + ") = " + (resultat1 / resultat2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
