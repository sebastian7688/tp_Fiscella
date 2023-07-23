using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract05
{
    internal class Program
    {
        //Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.

        static void Main(string[] args)
        {
            float num1, num2, num3, num4, suma, promedio;
            string linea;
            Console.Write("Ingrese el primer valor: ");
            linea = Console.ReadLine();
            num1 = float.Parse(linea);
            Console.Write("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            num2 = float.Parse(linea);
            Console.Write("Ingrese el trcer valor: ");
            linea = Console.ReadLine();
            num3 = float.Parse(linea);
            Console.Write("Ingrese el cuarto valor: ");
            linea = Console.ReadLine();
            num4 = float.Parse(linea);
            suma = num1 + num2 + num3 + num4;
            promedio = suma / 4;
            Console.WriteLine("La suma de los valores ingresados es " + suma);
            Console.WriteLine("El promedio de los valores ingresados es "+ promedio);
            Console.ReadKey();

        }
    }
}
