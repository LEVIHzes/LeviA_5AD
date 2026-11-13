using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _23_LeviA_ToonDatum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adriaenssens Levi
            //12/11/2026
            //Toon Datum

            //Velden
            DateTime _datum = default(DateTime), _datum2 = DateTime.MinValue, _datum3 = DateTime.Now;
            bool herhalen = true;

            //Programma
            while (herhalen)
            {
                Console.Clear();
                Console.WriteLine($"De default datetime: {_datum}");
                Console.WriteLine($"Het minimum datetime: {_datum2}");
                Console.WriteLine($"De huidige datetime: {_datum3}");
                Thread.Sleep(1000);
            }
        }
           
    }
}
