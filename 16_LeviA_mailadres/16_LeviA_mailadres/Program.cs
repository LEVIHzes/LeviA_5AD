using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_LeviA_mailadres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adriaenssens Levi
            //22/10/2026
            //mailadres

            //Velden
            string _voornaam = null;
            string _achternaam = null;

            //Programma
            try
            {
                //Stap1: Voornaam vragen +opslaan
                Console.Write("Wat is uw voornaam: ");
                _voornaam = Console.ReadLine();
                Console.WriteLine("Druk op enter om door te gaan");
                Console.ReadKey();

                //Scherm wissen
                Console.Clear();

                //Stap2: Achternaam vragen+opslaan
                Console.Write("Wat is uw achternaam: ");
                _achternaam = Console.ReadLine();
                Console.WriteLine("Druk op enter om door te gaan");
                Console.ReadKey();

                //Scherm wissen
                Console.Clear();

                //Stap3: Juiste tekst tonen
                Console.WriteLine($"Je e-mail adress is: {_voornaam}.{_achternaam}@student.romercollege.be");
                Console.WriteLine("Druk op enter om het programma af te sluiten");
                Console.ReadKey();
            }
            catch
            {
                //Stap4:tekst als er iets fout gaat
                Console.WriteLine("Er ging iet fout!");
                Console.WriteLine("Druk op enter om het programma af te sluiten");
                Console.ReadKey();
            }


        }
    }
}
