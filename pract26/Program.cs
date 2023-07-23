using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract26
{
    internal class Program
    {
        //Realizar un programa que imprima 25 términos de la serie
        //11 - 22 - 33 - 44, etc. (No se ingresan valores por teclado)
        static void Main(string[] args)
        {
            int x=0, series=11;
            while (x<25)
            {
                Console.Write(series);
                Console.Write(" - ");
                series = series + 11;
                x++;
            }
            Console.ReadKey();
        }
    }
}
