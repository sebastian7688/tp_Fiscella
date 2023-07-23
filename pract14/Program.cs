using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract14
{
    internal class Program
    {
        //Confeccionar un programa que permita cargar un número entero positivo
        //de hasta tres cifras y muestre un mensaje indicando si tiene 1, 2, o 3 cifras.
        //Mostrar un mensaje de error si el número de cifras es mayor.
        static void Main(string[] args)
        {
            int num1;
            string linea;
            Console.Write("Ingresar el valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            if (num1 > 0 && num1<=999)
            {
                if (num1 <= 9)
                {
                    Console.WriteLine("El numero tiene una cifra");
                }
                else if (num1 <= 99)
                {
                    Console.WriteLine("El numero tiene dos cifras");
                }
                else if (num1 <= 999)
                {
                    Console.WriteLine("El numero tiene tres cifras");
                }
            } else
            {
                Console.WriteLine("Fuera de rango (1-999)");
            }
            Console.ReadKey();
        }
    }
}
