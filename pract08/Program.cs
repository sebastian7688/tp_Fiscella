using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract08
{
    internal class Program
    {
        //Realizar un programa que solicite ingresar dos números
        //distintos y muestre por pantalla el mayor de ellos.

        static void Main(string[] args)
        {
            int num1, num2;
            string linea;
            Console.Write("Ingrese el primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            if (num1 != num2) 
            {
                if (num1 > num2)
                {
                    Console.WriteLine("El numero con mayor valor es " + num1);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El numero con mayor valor es " + num2);
                    Console.ReadKey();
                }
            }else 
            {
                Console.WriteLine("Los valores ingresados son iguales y no se pueden comparar");
                Console.ReadLine();
            }
        }
    }
}
