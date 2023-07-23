using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pract56
{
    //Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la primer fila,
    //2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
    //(crearla sin la intervención del operador)
    //Realizar la carga por teclado e imprimir posteriormente.
    class Matriz
    {
        private int[][] numero;
        public void Carga()
        {
            string linea;
            numero = new int[5][];
            for (int f = 0; f < numero.Length; f++)
            {
                numero[f] = new int[f + 1];
                Console.WriteLine("Fila "+f);
                for (int i = 0; i < numero[f].Length;i++)
                {
                    Console.Write("Ingrese el componente: ");
                    linea = Console.ReadLine();
                    numero[f][i]= int.Parse(linea);
                }
            }
        }
        public void Imprimir() 
        {
            for (int f=0;f<numero.Length;f++)
            {
                for (int i = 0; i < numero[f].Length;i++)
                {
                    Console.Write(numero[f][i]+"  ");
                }
            }
        }
        static void Main(string[] agrs)
        {
            Matriz m = new Matriz();
            Console.WriteLine("Carga de elementos");
            m.Carga();
            Console.WriteLine();
            Console.WriteLine("Matriz Impresa");
            m.Imprimir();
            Console.ReadKey();
        }

    }
}
