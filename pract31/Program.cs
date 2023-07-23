using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract31
{
    internal class Program
    {
        //Desarrollar un programa que solicite la carga de 10 números
        //e imprima la suma de los últimos 5 valores ingresados.
        static void Main(string[] args)
        {
            int num, suma=0;
            string linea;
            for (int f =1; f<=10;f++)
            {
                Console.Write("Ingrese el valor del {0}° numero: ",f);
                linea = Console.ReadLine();
                num = int.Parse(linea);
                if (f>5)
                {
                    suma = suma + num;
                }
            }
            Console.WriteLine();
            Console.WriteLine("La suma de los ultimos 5 valores ingresados es "+ suma);
            Console.ReadKey();
        }
    }
}
