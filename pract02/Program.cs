using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, producto;
            string linea;
            Console.WriteLine("Ingrese primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("Ingrese segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            suma = num1 + num2;
            producto = num1 * num2;
            Console.WriteLine("La suma de los valores ingresados es: "+ suma);
            Console.WriteLine("El producto de los valores ingresados es: "+producto);
            Console.ReadKey();
        }
    }
}
