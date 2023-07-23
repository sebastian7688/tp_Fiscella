using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract50
{
    //Cargar un vector de n elementos de tipo entero.Ordenar posteriormente el vector.
    class Vector 
    {
        private int[] enteros;
        private int n;
        public void Carga() 
        {
            string linea;
            int x = 1;
            Console.Write("Cantidad de pocisiones del vector: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            enteros = new int[n];
            for (int f=0;f<enteros.Length;f++)
            {
                Console.Write("Ingrese {0}° valor: ",x);
                linea=Console.ReadLine();
                enteros[f]= int.Parse(linea);
                x++;
            }
        }
        public void Ordenamiento() 
        {
            int help;
            for (int f=0;f<enteros.Length;f++)
            {
                for (int i = 0; i < enteros.Length - 1-f; i++)
                {
                    if (enteros[i] > enteros[i + 1])
                    {
                        help = enteros[i];
                        enteros[i] = enteros[i + 1];
                        enteros[i + 1] = help;
                    }
                }
            }
        }
        public void Imprimir() 
        {
            Console.WriteLine("El vector ordenado de menor a mayor: ");
            for (int f=0;f<enteros.Length;f++) 
            {
                Console.WriteLine(enteros[f]);
            }
        }
        static void Main(string[] args)
        {
            Vector v = new Vector();
            v.Carga();
            Console.WriteLine();
            v.Ordenamiento();
            v.Imprimir();
            Console.ReadKey();
        }
    }
}
