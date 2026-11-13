using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_LeviA_ModDeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adriaenssens Levi
            //12/11/2026
            //ModDeling

            //Velden
            const double _deler = 7;
            const double _deeltal = 29;

            //Programma
            Console.WriteLine("Deel 29/7");
            Console.WriteLine($"De deling: {(_deeltal / _deler).ToString()}\n");
            Console.WriteLine($"7 gaat {(Convert.ToInt32(_deeltal / _deler)).ToString()} keer in 29");
            Console.WriteLine($"De modulaire deling: {(_deeltal % _deler).ToString()}\n");

        }
    }
}
