using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract34
{
    internal class Program
    {
        //Realizar un programa que lea los lados de n triángulos, e informar:
        //a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados iguales), isósceles(dos lados iguales), o escaleno(ningún lado igual)
        //b) Cantidad de triángulos de cada tipo.
        //c) Tipo de triángulo que posee menor cantidad.
        static void Main(string[] args)
        {
            int n, cantidadEqui=0, cantidadIso=0, cantidadEsca = 0;
            float lado1, lado2, lado3;
            string linea;
            Console.Write("Ingrese la cantidad de triangulos a procesar: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            Console.WriteLine();
            for (int f=1;f<=n;f++) 
            {
                Console.Write("Ingresar el lado uno del {0}° Triangulo: ",f);
                linea = Console.ReadLine();
                lado1 = float.Parse(linea);
                Console.Write("Ingresar el lado dos del {0}° Triangulo: ",f);
                linea = Console.ReadLine();
                lado2 = float.Parse(linea);
                Console.Write("Ingrese el lado tres del {0}° Triangulo: ",f);
                linea = Console.ReadLine();
                lado3 = float.Parse(linea);
                Console.WriteLine();
                if (lado1 == lado2 && lado2 == lado3)
                {
                    cantidadEqui++;
                    Console.WriteLine("El triangulo es equilatero");
                }
                else if (lado1 != lado2 && lado2 != lado3)
                {
                    cantidadEsca++;
                    Console.WriteLine("El triangulo es escaleno");
                }
                else 
                {
                    cantidadIso++;
                    Console.WriteLine("El triangulo es Isoceles");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Hay {0} triangulos equilateros",cantidadEqui);
            Console.WriteLine("Hay {0} triangulos isoceles",cantidadIso);
            Console.WriteLine("hay {0} triangulos escalenos", cantidadEsca);
            if (cantidadEqui < cantidadEsca && cantidadEqui < cantidadIso)
            {
                Console.WriteLine("Hay menor cantidad de triangulo equilateros");
            }
            else if (cantidadEsca < cantidadEqui && cantidadEsca < cantidadIso)
            {
                Console.WriteLine("Hay menor cantidad de triangulos escalenos");
            }
            else 
            {
                Console.WriteLine("hay menor cantidad de triangulos isoceles");
            }
            Console.ReadLine();
        }
    }
}
