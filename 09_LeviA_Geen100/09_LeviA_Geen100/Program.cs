using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _09_LeviA_Geen100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adriaenssens Levi
            //09/10/2026
            //Project:Geen 100

            //Velden
            int _Getal = 0;
            int _Honderd = 0;

            //Programma

         try
            {  //Stap 1:Intro

                //Stap 2: Vraag getal +Opslaan
                Console.WriteLine("Geef uw getal");
                _Getal = int.Parse(Console.ReadLine());
                //Stap 3: Evalueer of het getal 100 is
                //Als groter dan 100 toon tekst
                if (_Getal > _Honderd)
                {
                    Console.WriteLine("Je getal is groter dan 100");
                    Console.WriteLine("\nDruk op enter om verder te gaan.");
                    Console.ReadKey();
                }

                //Als kleiner dan 100 toon tekst
                else if (_Getal < _Honderd)
                {
                    Console.WriteLine("Het getal is kleiner dan 100");
                    Console.WriteLine("\nDruk op enter om verder te gaan.");
                    Console.ReadKey();
                }

                //Als 100 toon tekst
                else
                {
                    Console.WriteLine("Dit is tegen de regels");
                    Console.WriteLine("\nDruk op enter om verder te gaan.");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Er ging iets fout,probeer opnieuw.");
                Console.WriteLine();

            }
        }
    }
}
