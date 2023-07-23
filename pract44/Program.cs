using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pract44
{
    //Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
    //El valor acumulado de todos los elementos del vector.
    //El valor acumulado de los elementos del vector que sean mayores a 36.
    //Cantidad de valores mayores a 50.
    class Vector
    {
        private int[] vector;
        public void Carga()
        {
            string linea;
            int c = 1;
            vector = new int[8];
            for (int f = 0; f < 8; f++)
            {
                Console.Write("Ingresar el {0}° valor: ", c);
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
                c++;
            }
        }
        public int SumaTotal()
        {
            int suma = 0;
            int x = vector.Count();
            for (int g = 0; g < x; g++)
            {
                suma = suma + vector[g];
            }
            return suma;
        }
        public int Mayor36()
        {
            int suma = 0;
            int x = vector.Count();
            for (int h=0;h<x;h++) 
            {
                if (vector[h]>=36)
                {
                    suma = suma + vector[h];
                }
            }
            return suma;
        }
        public int Mayor50()
        {
            int cant = 0;
            int x = vector.Count();
            for (int j=0;j<x;j++)
            {
                if (vector[j]>=50)
                {
                    cant++;
                }
            }
            return cant;
        }
        static void Main(string[] args)
        {
            Vector v = new Vector();
            v.Carga();
            Console.WriteLine();
            Console.WriteLine("La suma de todos los valores es "+ v.SumaTotal());
            Console.WriteLine("La suma de los valores mayores de 36 es "+ v.Mayor36());
            Console.WriteLine("La cantidad de valores mayores a 50 es "+ v.Mayor50());
            Console.ReadKey();
        }
    }
}
