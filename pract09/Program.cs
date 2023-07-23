using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pract09
{
    internal class Program
    {
        //Realizar un programa que lea por teclado dos números, si el primero es mayor al
        //segundo informar su suma y diferencia, en caso contrario informar el producto y
        //la división del primero respecto al segundo.
        static void Main(string[] args)
        {
            float num1, num2, suma,diferencia,producto,cociente;
            string linea;
            Console.Write("ingrese el primer valor: ");
            linea = Console.ReadLine();
            num1 = float.Parse(linea);
            Console.Write("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            suma = num1 + num2;
            diferencia = num1 - num2;
            producto = num1 * num2;
            cociente = num1 / num2;
            if (num1 > num2)
            {
                Console.WriteLine("La suma de los valores Ingresados es " + suma);
                Console.WriteLine("El resto de los valores ingresados es " + diferencia);
            }
            else 
            {
                Console.WriteLine("El producto de los valores ingresados es "+ producto);
                Console.WriteLine("El cociente de los valores ingresados es "+ cociente);
            }
            Console.ReadKey();

        }
    }
}
