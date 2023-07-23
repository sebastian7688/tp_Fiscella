using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pract03
{
    internal class Program
    {
        //Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del
        //mismo(El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro)
        static void Main(string[] args)
        {
            int lado, perimetro;
            string linea;
            Console.WriteLine("Ingrese la longitud de un lado del cuadrado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
            perimetro = lado * 4;
            Console.WriteLine("El perimetro del cuadrado es: "+perimetro);
            Console.ReadKey();
        }
    }
}
