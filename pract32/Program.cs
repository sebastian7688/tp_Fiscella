using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace pract32
{
    internal class Program
    {
        //Desarrollar un programa que muestre la tabla de multiplicar del 5 (del 5 al 50)
        //Ver video
        static void Main(string[] args)
        {
            int tabla5, cinco=5;
            for (int f =1; f<=10;f++)
            {
                tabla5 = cinco * f;
                Console.WriteLine("{0}*{1}={2}",cinco,f,tabla5);
            }
            Console.ReadKey();
        }
    }
}
