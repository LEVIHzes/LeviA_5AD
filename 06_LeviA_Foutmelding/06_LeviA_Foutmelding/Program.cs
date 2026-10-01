using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_LeviA_Foutmelding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adriaenssens Levi
            //01/10/2026
            //project: Foutmelding

            //Velden
            int _getal = 0;

            //Pragramma

            try
            {
                // stap 1:Vraag een getal + opslaan
                Console.WriteLine("Geef een natuurlijk getal:");
                _getal = int.Parse(Console.ReadLine());

                //Scherm leegmaken
                Console.Clear();

                //Stap 2: Toon de tekst of de foutmelding 
                Console.WriteLine("Getal ontvangen.");

            }
            catch
            {
                //Scherm leegmaken
                Console.Clear();

                //Stap 2: Toon de tekst of de foutmelding 
                Console.WriteLine("Er ging iets fout.");


            }
        }
    }
}