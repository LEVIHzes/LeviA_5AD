using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _10_LeviA_Keuzemenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adriaenssens Levi
            //13/10/2026
            //Keuzemenu

            //Velden
            Byte _Keuze = 0;

            //Programma
            do
            {
                //Scherm wissen
                Console.Clear();

                //Stap 1:toon keuzemenu
                Console.WriteLine("Maak uw keuze");
                Console.WriteLine("\n   1) Keuze 1 \n   2) Keuze 2 \n   3) Keuze 3 \n   4)Keuze 4");
                
                try
                {
                    //Stap 2:Vraag de keuze + Opslaan
                    Console.WriteLine("\nUw keuze");
                    _Keuze = Byte.Parse(Console.ReadLine());
                    //Stap3: Toon de juiste tekst afhankelijk van de keuze
                    //als 1
                    if (_Keuze==1)
                    {
                        Console.WriteLine("U koos keuze 1");
                        Console.WriteLine("Druk op enter om het programma af te sluiten.");
                    }
                    //als 2
                    else if(_Keuze==2)
                    {
                        Console.WriteLine("U koos keuze 2");
                        Console.WriteLine("Druk op enter om het programma af te sluiten.");
                    }
                    //als 3
                    else if(_Keuze==3)
                    {
                        Console.WriteLine("U koos keuze 3");
                        Console.WriteLine("Druk op enter om het programma af te sluiten.");
                    }
                    //als 4
                    else if(_Keuze==4)
                    {
                        Console.WriteLine("Tot de volgende keer!");
                    }
                    //als iets ander
                    else
                    {
                        Console.WriteLine("U gaf geen geldige keuze in!");
                    }
                }
                catch
                {
                    //scherm wissen
                    Console.Clear();
                    //Foutmelding
                    Console.WriteLine("U gaf geen getal in!");
                    Console.WriteLine("\n Druk op enter om naar het keuzemenu te gaan.");
                    Console.ReadKey();

                }

                //Stap 4:Al de keuze 4 is ga naar stap 1}

            } while (_Keuze != 4);



        }
    }
}
