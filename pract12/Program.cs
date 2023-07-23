using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract12
{
    internal class Program
    {
        //Se cargan por teclado tres números distintos.Mostrar por pantalla el mayor de ellos.
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string linea;
            Console.Write("Ingresar el primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingresar el segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingresar el tercer valor: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El numero mayor es " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("El numero mayor es " + num2);
            }
            else 
            {
                Console.WriteLine("El numero mayor es "+ num3);
            }
            Console.ReadKey();
        }
    }
}
