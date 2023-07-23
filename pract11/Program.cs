using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract11
{
    internal class Program
    {
    //Se ingresa por teclado un número positivo de uno o dos dígitos(1..99) mostrar
    //un mensaje indicando si el número tiene uno o dos dígitos.
    //(Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)
        static void Main(string[] args)
        {
            int num1;
            string linea;
            Console.Write("Ingrese el valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            if (num1 >= 1 && num1 <= 99)
            {
                if (num1 <= 9)
                {
                    Console.WriteLine("El numero tiene un digito");
                }
                else
                {
                    Console.WriteLine("El numero tiene dos digitos");
                }
            }
            else 
            {
                Console.WriteLine("Numero Fuera de rango (1-99)");
            }
            Console.ReadKey();
        }
    }
}
