using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pract29
{
    internal class Program
    {
        //Desarrollar un programa que permita cargar n números enteros y luego
        //nos informe cuántos valores fueron pares y cuántos impares.
        //Emplear el operador “%” en la condición de la estructura condicional:
	    //if (valor%2==0)         //Si el if da verdadero luego es par.
        static void Main(string[] args)
        {
            int x=0, n,valor,par=0,impar=0;
            string linea;
            Console.Write("Ingresar cantidad de numeros enteeros: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            Console.WriteLine();
            while (x<n)
            {
                x++;
                Console.Write("Ingresar el {0}° valor: ",x);
                linea= Console.ReadLine();
                valor = int.Parse(linea);
                if (valor % 2 == 0)
                {
                    par++;
                }
                else 
                {
                    impar++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Cantidad de numeros pares: "+ par);
            Console.WriteLine("Cantidad de numeros impares: "+impar);
            Console.ReadKey();
        }
    }
}
