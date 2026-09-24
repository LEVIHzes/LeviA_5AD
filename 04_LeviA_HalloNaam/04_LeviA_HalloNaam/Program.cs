using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LeviA_HalloNaam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adriaenssens Levi
            // 22/09/2026
            // Project Hallo naam

            //Velden
            String _naamGebruiker =null;
            String _bewerking = null;
            //programma

            //Stap 1:Vraag naam + opslaan
            Console.WriteLine("Geef uw naam:");
            _naamGebruiker = Console.ReadLine();

            //Stap 2:Maak de juiste tekst
            //_bewerking = "Hallo+" + _naam
            //_bewerking = string.Format("hallo{0}", _naamGebruiker);
            _bewerking = $"Hallo { _naamGebruiker} \n Mijn naam is LEVIHzes en ik ben de programmeur.";

            //scherm wissen
            Console.Clear();

            //Stap 3:Toon de tekst in de juiste vorm
            Console.WriteLine(_bewerking);  

        }
    }
}
