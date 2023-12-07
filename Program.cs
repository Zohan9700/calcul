/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            string choix; // saisie du choix de l'utilsiateur
            

            // boucle sur le menu
            choix = "1";
            while (choix != "0")
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                choix = Console.ReadLine();
                // traitement des choix
                if (choix != "0")
                {
                    switch (choix)
                    {
                        case "1":
                            bool correct = false;
                            // choix de l'addition
                            val1 = rand.Next(1, 10);
                            val2 = rand.Next(1, 10);
                            // saisie de la réponse
                            while (!correct)
                            {
                                try
                                {
                                    Console.Write(val1 + " + " + val2 + " = ");
                                    reponse = int.Parse(Console.ReadLine());
                                    // comparaison avec la bonne réponse
                                    solution = val1 + val2;
                                    if (reponse == solution)
                                    {
                                        Console.WriteLine("Bravo !");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                                    }
                                    correct = true;
                                }
                                catch
                                {
                                    Console.WriteLine("erreur de saisie : veuillez saisir un nombre entier");
                                }
                            }
                            break;

                        case "2":
                            bool correct2 = false;
                            // choix de la multiplication
                            val1 = rand.Next(1, 10);
                            val2 = rand.Next(1, 10);
                            // saisie de la réponse
                            while (!correct2)
                            {
                                try
                                {
                                    Console.Write(val1 + " x " + val2 + " = ");
                                    reponse = int.Parse(Console.ReadLine());
                                    // comparaison avec la bonne réponse
                                    solution = val1 * val2;
                                    if (reponse == solution)
                                    {
                                        Console.WriteLine("Bravo !");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                                    }
                                    correct2 = true;
                                }
                                catch
                                {
                                    Console.WriteLine("erreur de saisie : veuillez saisir un nombre entier");
                                }
                            }
                            
                            break;
                        default:
                            Console.WriteLine("erreur de saisie");
                            break;

                    }
                   
                }
                    
                    

            }
        }
    }
}
