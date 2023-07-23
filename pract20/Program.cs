using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace pract20
{
    internal class Program
    {
        //Escribir un programa que pida ingresar la coordenada de un punto en el plano,
        //es decir dos valores enteros x e y(distintos a cero).
        //Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto.
        //1º Cuadrante: x > 0 Y y > 0
        //2º Cuadrante: x < 0 Y y > 0
        //3° Cuadrante: x > 0 Y y < 0
        //4° Cuadrante. x < 0 Y y < 0
        static void Main(string[] args)
        {
            int x, y;
            string linea;
            Console.Write("Ingresar el valor de x: ");
            linea = Console.ReadLine();
            x = int.Parse(linea);
            Console.Write("Ingresar el valor de y: ");
            linea = Console.ReadLine();
            y = int.Parse(linea);
            if (x!=0&&y!=0) 
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("El punto se encuentra en el 1°cuadrante");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("El punto se encuentra en el 2°Cuadrante");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("El punto se encuentra en el 3°Cuadrante");
                }
                else 
                {
                    Console.WriteLine("El punto se encuentra en el 4°Cuadrante");
                }
                Console.ReadKey();
            }
        }
    }
}
