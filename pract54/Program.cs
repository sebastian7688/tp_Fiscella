using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace pract54
{
    //Crear una matriz de n* m filas(cargar n y m por teclado) Imprimir los cuatro valores
    //que se encuentran en los vértices de la misma(mat[0][0] etc.)
    class Vertices
    {
        private int[,] enteros;
        public void Carga() 
        {
            string linea;
            int filas, columna;
            Console.Write("Ingrese la cantidad de filas: ");
            linea = Console.ReadLine();
            filas = int.Parse(linea);
            Console.Write("Ingrese la cantidad de columnas: ");
            linea = Console.ReadLine();
            columna = int.Parse(linea);
            enteros = new int[filas,columna];
            for (int i=0;i<enteros.GetLength(0);i++)
            {
                for (int f=0;f<enteros.GetLength(1);f++)
                {
                    Console.Write("Ingresar el {0}° Valor de la fila {1}: ", f + 1, i + 1);
                    linea = Console.ReadLine();
                    enteros[i,f]= int.Parse(linea);
                }
            }
        }
        public void ImprimirVertice() 
        {
            Console.WriteLine("{0} - {1} - {2} - {3}", enteros[0, 0], enteros[0, enteros.GetLength(1)-1],
            enteros[enteros.GetLength(0)-1, 0], enteros[enteros.GetLength(0)-1, enteros.GetLength(1)-1]) ;
        }
        static void Main(string[] args) 
        {
            Vertices v = new Vertices();
            v.Carga();
            Console.WriteLine();
            v.ImprimirVertice();
            Console.ReadKey();
        }
    }
}
