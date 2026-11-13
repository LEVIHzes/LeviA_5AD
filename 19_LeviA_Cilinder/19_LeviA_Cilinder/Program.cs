using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_LeviA_Cilinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adriaenssens Levi
            //29/10/2026
            //Cilinder

            //Velden
            int _straal = 0;
            int _hoogte = 0;
            int _inhoud = 0;
            int _omtrek = 0;

            //Programma
            try
            {
                //Stap1: Straal vragen +opslaan
                Console.Write("Geef de straal van je cilinder: ");
                _straal = int.Parse(Console.ReadLine());
                Console.WriteLine("Druk op enter om verder te gaan.");
                Console.ReadKey();

                //Stap2: Hoogte vragen +opslaan
                Console.Write("Geef de hoogte van je cilinder: ");
                _hoogte = int.Parse(Console.ReadLine());
                Console.WriteLine("Druk op enter om verder te gaan.");
                Console.ReadKey();

                //Stap3: Inhoud & omtrek berekenen
                _inhoud = _hoogte * Math.Pow(_straal, 2) * Math.PI;
                _omtrek = 2 * Math.PI * _straal;

                //Stap4: Juiste tkest tonen
                Console.WriteLine($"De inhoud van de cilinder is {_inhoud} En de omtrek is {_omtrek}.");
                Console.WriteLine("Druk op enter om het programma af te sluiten.");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("U gaf geen geldig getal in!");
                Console.WriteLine("Druk op enter om het programma af te sluiten.");
                Console.ReadKey();
            }
            

        }
    }
}
