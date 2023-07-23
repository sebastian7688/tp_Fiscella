using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract33
{
    internal class Program
    {
        //Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos muestre 
        //la tabla de multiplicar del mismo(los primeros 13 términos)
        //Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.
        static void Main(string[] args)
        {
            int tabla, valor;
            string linea;
            Console.Write("Ingrese el numero a procesar: ");
            linea = Console.ReadLine();
            valor = int.Parse(linea);
            for (int f = 1; f <= 13; f++)
            {
                tabla = valor * f;
                Console.WriteLine("{0}*{1}={2}",valor, f, tabla);
            }
            Console.ReadKey();
        }
    }
}
