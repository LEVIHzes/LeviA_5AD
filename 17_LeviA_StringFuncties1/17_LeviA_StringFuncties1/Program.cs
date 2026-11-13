using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_LeviA_StringFuncties1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adriaenssens Levi
            //27/10/2026
            //StringFuncties

            //Velden
            Byte _keuze = 0;
            String _zin = null;
            Byte _keuze2 = 0;


            //Programma

            

            do
            {
                //scherm wissen
                Console.Clear();

                Console.WriteLine("Geef uw keuze uit onderstaand menu :");
                Console.WriteLine("   1)Geef een woord of zin die minimum 5 tekens is. \n   2)Voer bewerkingen uit op de zin of woord");
                _keuze = Byte.Parse(Console.ReadLine());
                //Als 1
                if (_keuze == 1)
                {
                    Console.WriteLine("Geef uw woor of zin :");
                    _zin = Console.ReadLine();

                    //scherm wissen
                    Console.Clear();

                }
                //Als 2
                else if (_keuze == 2)
                {
                    Console.WriteLine("Wat wilt u met uw zin of woord doen:");
                    Console.WriteLine("   1)Zeg hoveel tekens het bevat");
                    Console.WriteLine("   2)Zet elke letter in een hoofdletter");
                    Console.WriteLine("   3)Zet elke letter in een kleine letter");
                    Console.WriteLine("   4)Toon de eersre 3 tekens");
                    Console.WriteLine("   5)Toon de laatste 4 letters");
                    Console.WriteLine("   6)Zet 5 spaties voor en achter de zin");
                    Console.WriteLine("   7)Verwijder de spaties voor het woord");
                    Console.WriteLine("   8)Zet 5 spaties voor en achter de zin");
                    Console.WriteLine("   9)Verwijder de spaties voor en na het woord");
                    Console.WriteLine("   10)Zoek of er een 'e' in het woord zit");
                    Console.WriteLine("   11)Geef een tweede zin");
                    _keuze2 = Byte.Parse(Console.ReadLine());

                    //scherm wissen
                    Console.Clear();

                }
                //Zeg hoeveel tekens het bevat
                if(_keuze2 == 1)
                {
                    Console.WriteLine($"{_zin.Length}");
                    Console.WriteLine("Druk op enter om terug naar het hoofmenu te gaan.");
                    Console.ReadKey();

                    //scherm wissen
                    Console.Clear();
                }
                //Zet elke letter in een hoofdletter en toon het woord.
                else if(_keuze2 == 2)
                {
                    Console.WriteLine($"{_zin.ToUpper()}");
                    Console.WriteLine("Druk op enter om terug naar het hoofmenu te gaan.");
                    Console.ReadKey();

                    //scherm wissen
                    Console.Clear();
                }
                //Zet elke letter in een kleine letter en toon het woord.
                else if (_keuze == 3)
                {
                    Console.WriteLine($"{_zin.ToLower()}");
                    Console.WriteLine("Druk op enter om terug naar het hoofmenu te gaan.");
                    Console.ReadKey();

                    //scherm wissen
                    Console.Clear();
                }
                //Wat de eerste 3 tekens zijn(toon deze op het scherm)
                else if(_keuze2 == 4)
                {
                    Console.WriteLine($"{_zin.Substring(0, 3)}");
                    Console.WriteLine("Druk op enter om terug naar het hoofmenu te gaan.");
                    Console.ReadKey();

                    //scherm wissen
                    Console.Clear();
                }
                //Wat de laatste 4 tekens zijn(toon deze op het scherm)
                //Zet 5 spaties voor en achter de zin. (toon op het scherm)
                //Verwijder de spaties voor het woord(toon op het scherm)
                //Verwijder de spaties achter het woord(toon op het scherm)
                //Zet 5 spaties voor en achter de zin. (toon op het scherm)
                //Verwijder de spaties voor EN achter het woord in 1 keer(toon op het scherm)
                //Zoek of er een e in het woord of de zin zit
                //a.Als er een e in de zin zit vervang je die door het cijfer 3
                //b.Als er geen e in het woord zit, zeg je “Niet van toepassing”
                //Vraag de gebruiker een 2de zin in te geven. 
                //a.Rangschik deze woorden alfabetisch
                //b.Tenzij ze identiek zijn, dan zeg je: “je gaf hetzelfde woord of dezelfde tekst in” 
            }
            while (_keuze != 2);


        }
    }
}
