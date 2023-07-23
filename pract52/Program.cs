using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Matriz2
{
    //Crear una matriz de 2 filas y 5 columnas.Realizar la carga de componentes por columna
    //(es decir primero ingresar toda la primer columna, luego la segunda columna y así sucesivamente)
    //Imprimir luego la matriz.
    class Matriz
    {
        private int[,] enteros;
        public void Carga()
        {
            string linea;
            enteros = new int[2, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int f = 0; f < 2; f++)
                {
                    Console.Write("Ingresar el {0}° valor de la columna {1}: ", f + 1, i + 1);
                    linea = Console.ReadLine();
                    enteros[f, i] = int.Parse(linea);
                }
            }
        }
        public void Imprimir()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int f = 0; f < 5; f++)
                {
                    Console.Write(enteros[i, f] + " - ");
                }
            }
        }
        static void Main(string[] args)
        {
            Matriz m = new Matriz();
            m.Carga();
            Console.WriteLine();
            m.Imprimir();
            Console.ReadKey();
        }

    }
}