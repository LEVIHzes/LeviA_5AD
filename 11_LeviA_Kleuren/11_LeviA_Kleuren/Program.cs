using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_LeviA_Kleuren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adriaenssens Levi
            //13/10/2026
            //Kleuren

            //Velden
            int _Keuze = 0;

            //Programma

            //Stap 1: keuze + opslaan
            Console.WriteLine("Kies een van de drie en schrijf het getal.\n 1. rood \n 2. groen \n 3. blauw.");
            _Keuze = byte.Parse(Console.ReadLine());

            //Scherm wissen
            Console.Clear();

            try
            {
                if (_Keuze == 1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Je koos volgende kleur rood");
                    Console.WriteLine("Druk op enter om het programma af te sluiten.");
                }

                else if (_Keuze == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Je koos volgende kleur groen");
                    Console.WriteLine("Druk op enter om het programma af te sluiten.");
                }

                else if (_Keuze == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Je koos volgende kleur blauw");
                    Console.WriteLine("Druk op enter om het programma af te sluiten.");
                }
            }
            catch
            {
                Console.WriteLine("Er ging iets fout");
            }

            

           

        }
    }
}
