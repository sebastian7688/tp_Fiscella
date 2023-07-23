using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pract36
{
    internal class Program
    {
        //Se realiza la carga de 10 valores enteros por teclado.Se desea conocer:
        //a) La cantidad de valores ingresados negativos.
        //b) La cantidad de valores ingresados positivos.
        //c) La cantidad de múltiplos de 15.
        //d) El valor acumulado de los números ingresados que son pares.
        static void Main(string[] args)
        {
            int num,  sumaPar=0, multiplos15=0, cantN=0, cantP=0;
            string linea;
            for (int f=1; f<=10;f++)
            {
                Console.Write("Ingresar el numero {0}: ",f);
                linea = Console.ReadLine();
                num = int.Parse(linea);
                if (num < 0)
                {
                    cantN++;
                }
                else if (num>0)
                {
                    cantP++;
                }
                if (num%15==0)
                {
                    multiplos15++;
                }
                if (num%2==0)
                {
                    sumaPar = sumaPar + num;
                }
            }
            Console.WriteLine();
            Console.WriteLine("La cantidad de valores ingresados positivos es "+cantP);
            Console.WriteLine("La cantidad de valores ingresados negativos es "+ cantN);
            Console.WriteLine("La cantidad de multiplos de 15 es " + multiplos15);
            Console.WriteLine("La suma total de los valores pares es "+sumaPar);
            Console.ReadKey();
        }
    }
}
