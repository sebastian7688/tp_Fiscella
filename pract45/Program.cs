using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract45
{
    //Realizar un programa que pida la carga de dos vectores numéricos enteros de 4 elementos.
    //Obtener la suma de los dos vectores, dicho resultado guardarlo en un tercer vector del mismo tamaño.
    //Sumar componente a componente.
    class Numeros 
    {
        private int[] num1;
        private int[] num2;
        private int[] suma;
        public void Carga1() 
        {
            string linea;
            int x = 1;
            num1 = new int[4];
            num2 = new int[4];
            Console.WriteLine("Vector 1");
            for (int h = 0; h < 4; h++)
            {
                Console.Write("Ingresar el {0}° Valor: ", h+1);
                linea = Console.ReadLine();
                num1[h] = int.Parse(linea);
                x++;
            }
            
            Console.WriteLine("Vector 2");
            for (int f = 0; f < 4; f++)
            {
                Console.Write("Ingresar el {0}° Valor: ", f+1);
                linea = Console.ReadLine();
                num2[f] = int.Parse(linea);
                x++;
            }
        }
        public void Suma() 
        {
            suma = new int[4];
            for (int f=0;f<4;f++)
            {
                suma[f] = num1[f] + num2[f];
            }
            for (int g=0;g<4;g++)
            {
                Console.WriteLine("La suma de los dos vectoreses "+ suma[g]);
            }
        }
        static void Main(string[] args)
        {
            Numeros n = new Numeros();
            n.Carga1();
            Console.WriteLine();
            n.Suma();
            Console.ReadKey();
        }
    }
}
