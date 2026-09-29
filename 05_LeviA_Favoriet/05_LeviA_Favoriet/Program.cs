using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LeviA_Favoriet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adriaenssens Levi
            //29/09/2026
            //Favoriet

            //velden
            string _kleur = null;
            string _bewerking = null;
            string _dag = null;
            string _seizoen = null;

            //kleur
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            //programma

            //Stap 1:Vraag de favoriete kleur +opslaan
            Console.WriteLine("Kies een kleur:");
            _kleur = Console.ReadLine();
            //Stap 2:Maak de juiste tekst
            _bewerking = $"Je koos { _kleur}";

            // scherm wissen
            Console.Clear();

            //Stap 3 :Toon de juiste tekst
            Console.WriteLine(_bewerking);
            Console.WriteLine("Druk op enter om verder te gaan");
            Console.ReadKey();

            //scherm wissen
            Console.Clear();

            //Stap 4:Vraag de Favoriete dag van de week + opslaan
            Console.WriteLine("Geef je favoriete week dag:");
            _dag = Console.ReadLine();
            //Stap 5:Maak de juiste tekst
            _bewerking = $"Je favoriete dag is {_dag}";

            //scherm wissen
            Console.Clear();

            //Stap 6 :Toon de juiste tekst
            Console.WriteLine(_bewerking);
            Console.WriteLine("Druk op enter om verder te gaan");
            Console.ReadKey();

            //scherm wissen
            Console.Clear();

            //Stap 7:Vraag het favoriet seizoen +opslaan
            Console.WriteLine("Geef je favoriete seizoen: ");
            _seizoen = Console.ReadLine();
            //Stap 8:Maak de juiste tekst
            _bewerking = $"Je favoriete seizoen is {_seizoen}";

            //scherm wissen
            Console.Clear();

            //Stap 9 :Toon de juiste tekst
            Console.WriteLine(_bewerking);
            Console.WriteLine("Druk twee keer op enter om het programma af te sluiten");
            Console.ReadKey();
        }
    }
}
