using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_LeviA_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adriaenssens Levi
            //16/10/2026
            //Random

            // Velden
            Byte _keuze = 0;
            Random _rdm1 = new Random();
            Random _rdm2 = new Random();
            int _getal1 = -1;
            int _getal2 = -1;
            // Programma
            do
            {
                // Scherm wissen
                Console.Clear();

                // Toon keuzemenu
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("    1) Maak 2 randoms zonder voorwaarde \n    2) Maak 2 verschillende willekeurige getallen \n    3) Maak 3 verschillende willekeurige getallen \n    4) Aflsuiten");
                
                try
                {
                    // Vraag de keuze + opslaan
                    Console.Write("\nGeef uw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    // Als 1:
                    if (_keuze == 1)
                    {
                        //Maak 2 willekeurige getallen
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm2.Next();

                        // Toon ze op het scherm
                        Console.WriteLine($"De twee getallen zijn {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    // Als 2
                    else if (_keuze == 2)
                    {
                        // Maak 2 willekeurige getallen
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm1.Next();

                        //Toon ze op het scherm
                        Console.WriteLine($"De twee getallen zijn {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    // Als 3
                    else if (_keuze == 3)
                    {
                        // Maak 2 willekeurige getallen
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm2.Next();

                        //Toon ze op het scherm
                        Console.WriteLine($"De twee getallen zijn {_getal1.ToString()} en {_getal2.ToString()}");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    // In elk ander geval
                    else if(_keuze==4) 
                    {
                        Console.WriteLine("Tot de volgende keer!");
                        Console.WriteLine("Druk op enter om verder te gaan");
                        Console.ReadKey();
                    
                    }
                    else
                    {
                        //Foutmelding
                        Console.WriteLine("U gaf geen geldige keuze in.");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    //Scherm wissen
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("\nDruk op enter om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();
                }
            }
            while (_keuze != 5);
        }
    }
}