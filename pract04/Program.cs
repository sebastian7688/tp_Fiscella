using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract04
{
    internal class Program
    {
        //Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma
        //de los dos primeros y el producto del tercero y el cuarto.
        static void Main(string[] args)
        {
            float num1, num2, num3, num4, suma, producto;
            string linea;
            Console.Write("Ingrese el primer valor: ");
            linea = Console.ReadLine();
            num1 = float.Parse(linea);
            Console.Write("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            num2 = float.Parse(linea);
            Console.Write("Ingrese el tercer valor: ");
            linea = Console.ReadLine();
            num3 = float.Parse(linea);
            Console.Write("Ingre el cuarto valor: ");
            linea = Console.ReadLine();
            num4 = float.Parse(linea);
            suma = num1 + num2;
            producto = num3 * num4;
            Console.WriteLine("La suma de los dos primeros valores es "+suma);
            Console.WriteLine("El producto de los dos ultimos valores es " + producto);
            Console.ReadKey();
        }
    }
}
