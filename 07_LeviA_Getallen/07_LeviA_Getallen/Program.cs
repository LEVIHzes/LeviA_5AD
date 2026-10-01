using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_LeviA_Getallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adriaenssens Levi
            //01/10/2026
            //Project:Getallen

            //Velden
            int _getal, _getal1, _getal2 = 0;

            //Programma

            //Vraag voor 3 getallen + opslaan
            try
            {
                Console.WriteLine("Geef je eerste getal: ");
                _getal = int.Parse(Console.ReadLine());

                //scherm wissen
                Console.Clear();

                //Vraag getal 2
                Console.WriteLine("Geef het tweede getal: ");
                _getal1 = int.Parse(Console.ReadLine());

                //scherm wissen
                Console.Clear();

                //Vraag het 3de getal
                Console.WriteLine("Geef het derde getal: ");
                _getal2 = int.Parse(Console.ReadLine());

                //scherm wissen
                Console.Clear();

                //Getallen weergeven
                Console.WriteLine($"Je derde getal is {_getal2.ToString()}.\n");
                Console.WriteLine($"Je tweede getal is {_getal1.ToString()}\n");
                Console.WriteLine($"Je eerste getal is {_getal.ToString()}\n");
            }
            catch
            {
                //scherm wissen
                Console.Clear();
                //foutmelding
                Console.WriteLine("Er ging iets fout.");
            }
        }
    }
}
