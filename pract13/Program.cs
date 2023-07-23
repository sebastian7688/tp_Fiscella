using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract13
{
    internal class Program
    {
        //Se ingresa por teclado un valor entero, mostrar una leyenda que indique
        //si el número es positivo, nulo o negativo.
        static void Main(string[] args)
        {
            int num1;
            string linea;
            Console.Write("Ingrese el valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            if (num1 == 0)
            {
                Console.WriteLine("El numero es nulo");
            }
            else if (num1 > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero es negativo");
            }
            Console.ReadKey();
        }
    }
}
