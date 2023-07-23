using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace pract38
{
    internal class Program
    {
        //Realizar un programa que acumule(sume) valores ingresados por teclado hasta ingresar el 9999
        //(no sumar dicho valor, indica que ha finalizado la carga).
        //Imprimir el valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.
        static void Main(string[] args)
        {
            int valor=0, suma=0;
            string linea;
            do 
            {
                suma = suma + valor;
                Console.Write("Ingrese un valor (finalice en 9999): ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                Console.WriteLine();
            }
            while (valor!=9999);
            Console.WriteLine("El valor acumulado es "+ suma);
            if (suma == 0)
            {
                Console.WriteLine("El valor acumulado es 0");
            }
            else if (suma < 0)
            {
                Console.WriteLine("El valor acumulado es negativo");
            }
            else 
            {
                Console.WriteLine("El valor acumulado es positivo");
            }
            Console.ReadKey();
        }
    }
}
