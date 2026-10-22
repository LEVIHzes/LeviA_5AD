using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _15_LeviA_MeerDobbelstenen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adriaenssens Levi
            //20/10/2026
            //MeerDobbelstenen

            //Velden
            Byte _keuze = 0;
            Byte _aantalogen = 0;
            Random _rdm1 = new Random();
            int _worp = -1;
            int _totaal = 0;
            
            //Proggramma
            do
            {
                //scherm wissen
                Console.Clear();

                Console.WriteLine("Maak uw keuzeuit onderstaand menu.");
                //Stap 1a:Toon eerste deel keuzemenu(ogen)
                Console.WriteLine("   1)Geef het aantal ogen van de dobbelsteen");


                //Stap 2:Kijk of het aantal ogen is ingegeven
                //Als Ja
                if (_aantalogen != 0)
                {
                    //Stap 3:Toon rest van keuzemenu(werpen, resetten)
                    Console.WriteLine("   2)Werp de dobbelsteen \n   3)Reset het totaal");
                }


                //Stap1b Toon eerste deel keuzemenu
                Console.WriteLine("   4)Afsluiten");

                try
                {
                    //Stap4: Vraag keuze +opslaan
                    Console.Write("\n Geef uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    //scherm wissen
                    Console.Clear();

                    //Als 1:
                    if (_keuze == 1)
                    {
                        //Stap5: Vraag hoeveel ogen de dobbelsteen heeft +opslaan
                        Console.Write("Geef het aantal ogen dat u voor de dobbelsteen wilt: ");
                        _aantalogen = Byte.Parse(Console.ReadLine());
                        _aantalogen++;
                        //_aantalogen
                    }

                    //Als2:
                    if (_keuze == 2)
                    {
                        
                        //Random aanmaken
                        _worp = _rdm1.Next(_aantalogen);

                        _totaal += _worp;

                        //Stap6: Toon de worp van de dobbelsteen +opslaan
                        Console.WriteLine($"Uw getal is {_worp.ToString()}");
                        
                       

                        //Stap7: Toon het totaal van van alle worpen tenzamen
                       
                        Console.WriteLine($"Het totaal is {_totaal.ToString()}");
                        Console.WriteLine("Druk op enter om terug te keren naar het hoofmenu.");
                        Console.ReadKey();

                    }



                    //Als 3:
                    if (_keuze == 3)
                    {
                        //Stap8: Reset het resultaat
                        _totaal = 0;
                        Console.WriteLine($"Het totaal is gereset");
                        Console.WriteLine("Druk op enter om terug te keren naar het hoofmenu.");
                        Console.ReadKey();

                    }

                    //Als 4:
                    if (_keuze == 4)
                    {
                        //Stap 9:Afsluittekst
                        Console.WriteLine("Tot een volgende keer");
                        Console.WriteLine("Druk op enter om het programma af te sluiten.");
                        Console.ReadKey();

                    }
                    //Stap10:Indien keuze niet 4 is,Ga terug naar stap 1  
                    else
                    {
                        Console.WriteLine("U gaf geen geldig getal in.");
                        Console.WriteLine("Druk op enter om terug naar het hoofmenu te keren.");
                        Console.ReadKey();
                    }

                     



                }
                catch
                {
                    //scherm wissen
                    Console.Clear();
                    //Foutmelding
                    Console.WriteLine("U gaf geen getal in");
                    Console.WriteLine("Druk op enter om naar het hoofmenu te gaan.");
                    Console.ReadKey();
                }
            }
            while (_keuze != 4);

        }
    }

}

