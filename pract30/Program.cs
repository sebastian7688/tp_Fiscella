using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pract30
{
    internal class Program
    {
        //Confeccionar un programa que lea n pares de datos, cada par de datos
        //corresponde a la medida de la base y la altura de un triángulo.El programa deberá informar:
        //a) De cada triángulo la medida de su base, su altura y su superficie.
        //b) La cantidad de triángulos cuya superficie es mayor a 12.
        static void Main(string[] args)
        {
            int n, baseTriangulo, alturaTriangulo, superficie, mayor12=0;
            string linea;
            Console.Write("Ingrese la cantidad de triangulos: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            Console.WriteLine();
            for (int f = 1; f <= n; f++)
            {
                Console.Write("Ingresar la base del triangulo {0}: ",f);
                linea = Console.ReadLine();
                baseTriangulo = int.Parse(linea);
                Console.Write("Ingresar la altura del triangulo {0}: ",f);
                linea = Console.ReadLine();
                alturaTriangulo = int.Parse(linea);
                superficie = baseTriangulo * alturaTriangulo / 2;
                Console.WriteLine("La superficie del triangulo es "+superficie);
                if (superficie>12) 
                {
                    mayor12++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("La cantidad de triangulo con superficie mayor a 12 son {0} triangulo", mayor12);
            Console.ReadKey();
        }
    }
}
