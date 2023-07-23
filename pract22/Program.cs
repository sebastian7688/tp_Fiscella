using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract22
{
    internal class Program
    {
        //Escribir un programa en el cual: dada una lista de tres valores numéricos
        //distintos se calcule e informe su rango de variación(debe mostrar el mayor y el menor de ellos)
        static void Main(string[] args)
        {
            int num1, num2, num3, min, max;
            string linea;
            Console.Write("Ingrese el primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingrese el tercer valor: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            if (num1!=num2 && num1!=num3 && num2!=num3)
            {
                if (num1 > num2 && num1 > num3 && num2 > num3)
                {
                    max = num1; min = num3;
                    Console.WriteLine("Numero mayor: {0} \nNumero menor: {1}",max,min);
                }
                else if (num1 > num2 && num1 > num3 && num2 < num3) 
                {
                    max = num1;min = num2;
                    Console.WriteLine("Numero mayor: {0} \nNumero menor: {1}" , max , min);

                }
                if (num2 > num1 && num2 > num3 && num1 > num3)
                {
                    max = num2; min = num3;
                    Console.WriteLine("Numero mayor: {0} \nNumero menor: {1}" , max , min);

                }
                else if (num2 > num1 && num2 > num3 && num1 < num3)
                {
                    max = num2;min = num1;
                    Console.WriteLine("Numero mayor: {0} \nNumero menor: {1}" , max , min);

                }
                if (num3 > num1 && num3 > num2 && num1 > num2)
                {
                    max = num3; min = num2;
                    Console.WriteLine("Numero mayor: {0} \nNumero menor: {1}" , max , min);

                }
                else if (num3>num1&&num3>num2&&num1<num2)
                {
                    max = num3;min = num1;
                    Console.WriteLine("Numero mayor: {0} \nNumero menor: {1}" , max , min);

                }
            }
            Console.ReadKey();
        }
    }
}
