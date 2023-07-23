using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract35
{
    internal class Program
    {
        //Escribir un programa que pida ingresar coordenadas(x, y) que representan puntos en el plano.
        //Informar cuántos puntos se han ingresado en el primer, segundo, tercer y cuarto cuadrante.
        //Al comenzar el programa se pide que se ingrese la cantidad de puntos a procesar.
        //1° cuadrante: x>0;y>0
        //2° cuadrante: x>0;y<0
        //3° cuadrante: x<0;y>0
        //4° cuadrante: x<0;y<0
        static void Main(string[] args)
        {
            int n, x, y, cuadrante1=0, cuadrante2=0, cuadrante3=0, caudrante4=0;
            string linea;
            Console.Write("Ingresar la cantidad de puntos a procesar: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            Console.WriteLine();
            for (int f=1;f<=n;f++)
            {
                Console.Write("Ingrese el valor de x del punto {0}: ",f);
                linea=Console.ReadLine();
                x = int.Parse(linea);
                Console.Write("Ingrese el valor de y del punto {0}: ",f);
                linea = Console.ReadLine();
                y = int.Parse(linea);
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("El punto se encuentra en el 1° Cuadrante");
                    cuadrante1++;
                }
                else if (x > 0 && y < 00)
                {
                    Console.WriteLine("El punto se encuentra en el 2° Cuadrante");
                    cuadrante2++;
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("El punto se encuentra en el 3° Cuadrante");
                    cuadrante3++;
                }
                else 
                {
                    Console.WriteLine("El punto se encuentra en el 4° Cuadrante");
                    caudrante4++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("En el 1° Cuadrante hay {0} puntos.",cuadrante1);
            Console.WriteLine("En el 2° Cuadrante hay {0} puntos.",cuadrante2);
            Console.WriteLine("En el 3° Cuadrante hay {0} puntos.",cuadrante3);
            Console.WriteLine("En el 4° Cuadrante hay {0} puntos.",caudrante4);

            Console.ReadKey();
        }
    }
}
