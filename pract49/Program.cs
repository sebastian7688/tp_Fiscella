using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pract49
{
    //Cargar un vector de n elementos.imprimir el menor y un mensaje si se repite dentro del vector.
    class Valores
    {
        private int[] num;
        private int min;
        public void Carga()
        {
            string linea;
            int n, x = 1;
            Console.Write("Ingresar la cantidad del vector: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            num = new int[n];
            for (int f=0; f<num.Length;f++) 
            {
                Console.Write("Ingresar el {0}° Valor: ",x);
                linea = Console.ReadLine();
                num[f] = int.Parse(linea);
                x++;
            }
        }
        public void Menor() 
        {
            min = num[0];
            int pos = 0;
            for (int f =1;f<num.Length;f++)
            {
                if (num[f]<min)
                {
                    min = num[f];
                    pos = f;
                }
            }
            Console.WriteLine("El menor valor del vector es {0} con la posicion {1} ",min,pos);
        }
        public void RepiteMenor() 
        {
            int x = 0;
            for (int f=1;f<num.Length;f++)
            {
                if (num[f]==min)
                {
                    x++;
                }
            }
            if (x > 1)
            {
                Console.Write("El volor minimo se repite dentro del vector");
            }
            else 
            {
                Console.Write("No se repite");
            }
        }
        static void Main(string[] args )
        {
            Valores v = new Valores();
            v.Carga();
            Console.WriteLine();
            v.Menor();
            Console.WriteLine();
            v.RepiteMenor();
            Console.ReadKey();
        }
    }
}
