using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_LeviA_ProjectRekensom
{
    internal class Program
    {
        static void Main(string[] args)
        {//Adriaenssens Levi
            //08/10/2026
            //Project:Rekensom

            //Velden
            int _Getal = 0;
            int _Getal1 = 0;
            int _bewerking,_bewerking1,_bewerking2,_bewerking3 = 0;

            //Programma
            try
            {
                //Stap 1:Vraag eerste getal + opslaan
                Console.WriteLine("Geef je eerste getal");
                _Getal = int.Parse(Console.ReadLine());

                //scherm wissen
                Console.Clear();
                try
                {
                    //Stap 2:Vraag 2de getal +opslaan
                    Console.WriteLine("Geef je tweede getal");
                    _Getal1 = int.Parse(Console.ReadLine());

                    //scherm wissen
                    Console.Clear();

                    //Stap 3:Getallen optellen
                    _bewerking = _Getal + _Getal1;

                    //Stap 4 Getallen met 5 optellen
                    _bewerking1 = _bewerking + 5;

                    //Stap 5:Uitkomst vermenigvuldigen met 10

                    _bewerking2 = _bewerking1 * 10;
                    //Stap 6: Uitkomst delen door 2

                    _bewerking3 = _bewerking2 / 2;

                    //Stap 7:Juiste tekst weergeven
                    Console.WriteLine($"U gaf het getal {_Getal.ToString()} en getal {_Getal1.ToString()} in.");
                    Console.WriteLine($"De som hiervan is {_bewerking.ToString()}");
                    Console.WriteLine($"Dit getal werd vermeerder met 5. Dit gaf als uitkomst {_bewerking1.ToString()}");
                    Console.WriteLine($"Daarna werd er vermenigvuldig met 10. Dit gaf als uitkomst {_bewerking2.ToString()}");
                    Console.WriteLine("Als laatste werd er gedeeld door 2 ");
                    Console.WriteLine($"Het uiteindelijke resultaat is {_bewerking3.ToString()}");
                    Console.WriteLine();
                    Console.WriteLine("Druk op enter om af te sluiten.");
                }
                catch
                {
                    //scherm wissen
                    Console.Clear();

                    //fout weergeven
                    Console.WriteLine("Je tweede getal is niet geldig");
                }
            }
            catch
            {
                //scherm wissen
                Console.Clear();

                //Foutmelding
                Console.WriteLine("Je eerste getal is niet geldig");
            }
               
            

        }
    }

}