using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _13_LeviA_Hallo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adriaenssens Levi
            //16/10/2026
            //Hallo Wereld

            //Velden
            Byte _Keuze = 0;
            String _Naam = null;
            //Programma

            

            do
            {
                //scherm wisssen
                Console.Clear();
                //Stap 1:Toon keuzemenu
                Console.WriteLine("Maak je keuze.\n   1) Hallo Wereld \n   2) Hallo naam \n   3) Sluit af");

                try
                { 

                    //Stap 2:Vraag de keuze + Opslaan
                    Console.WriteLine("\nUw keuze\n");
                    _Keuze = Byte.Parse(Console.ReadLine());

                    //scherm wisssen
                    Console.Clear();

                    //Stap 3:Toon tekst afhankelijk van keuze
                    //Stap4:Als 1 
                    if (_Keuze == 1)
                    {
                        //Stap5: Toon juiste tekst
                        Console.WriteLine("Hallo Wereld");
                        Console.WriteLine("\n");
                        Console.WriteLine("Druk op enter om terug naar het hoofdmenu te keren");
                        Console.ReadKey();
                    }

                    //Stap6:Als 2
                    else if (_Keuze == 2)
                    {
                        //Stap7: Vraag naam +opslaan
                        Console.WriteLine("Geef uw naam:\n");
                        _Naam = Console.ReadLine();

                        //scherm wissen
                        Console.Clear();

                        //Stap8: Juiste tekst laten zien
                        Console.WriteLine($"Hallo {_Naam}.");
                        Console.WriteLine("\n");
                        Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu");
                        Console.ReadKey();
                    }

                    //Als 3
                    else if (_Keuze == 3)
                    {
                        //Stap8: Juiste tekst laten zien
                        Console.WriteLine("Druk op enter om het programma af te sluiten");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("U gaf geen geldig getal in!\n");
                        Console.WriteLine("Druk op enter om terug te keren naar het menu");
                        Console.ReadKey();
                    }

                    
                }
                catch
                {
                    //scherm wisssen
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("U gaf geen getal in!\n");
                    Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu");
                    Console.ReadKey();
                }
            }
            while (_Keuze!=3);
            

            
        }   
    }
}
