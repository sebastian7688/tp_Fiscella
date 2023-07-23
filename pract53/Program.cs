using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace pract53
{
    //Crear una matriz de n* m filas(cargar n y m por teclado) Intercambiar
    //la primer fila con la segunda.Imprimir luego la matriz.
    class Matriz 
    {
        private int[,] matriz;
        public void Carga() 
        {
            string linea;
            int filas, columnas;
            Console.Write("Ingresar la cantidad de filas: ");
            linea = Console.ReadLine();
            filas = int.Parse(linea);
            Console.Write("Ingresar la cantidad de columnas: ");
            linea = Console.ReadLine();
            columnas = int.Parse(linea);
            matriz = new int[filas, columnas];
            for (int i=0; i<matriz.GetLength(0);i++)
            {
                for (int f=0;f<matriz.GetLength(1);f++) 
                {
                    Console.Write("Ingresar el {0}° Valor de la fila {1}: ",i+1,f+1);
                    linea = Console.ReadLine();
                    
                    
                    3matriz[i,f] = int.Parse(linea);
                }
            }
        }
        public void Intercambiar() 
        {
            int help;
            for (int f=0;f<matriz.GetLength(1);f++)
            {
                help = matriz[0,f];
                matriz[0, f] = matriz[1,f];
                matriz[1, f] = help;
            }
        }
        public void Imprimir() 
        {
            for (int i=0;i<matriz.GetLength(0);i++) 
            {
                for (int f = 0; f < matriz.GetLength(1); f++)
                {
                    Console.Write(matriz[i,f]+"-");
                }
            }
        }
        static void Main(string[] args)
        {
            Matriz m = new Matriz();
            m.Carga();
            Console.WriteLine();
            m.Intercambiar();
            Console.WriteLine();
            m.Imprimir();
            Console.ReadKey();
        }
    }
}
