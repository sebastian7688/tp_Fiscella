using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract06
{
    internal class Program
    {
        //Se debe desarrollar un programa que pida el ingreso del precio de un artículo
        //y la cantidad que lleva el cliente.Mostrar lo que debe abonar el comprador.
        static void Main(string[] args)
        {
            float precioArticulo, precioFinal;
            int cantidadComprada;
            string linea;
            Console.Write("Ingresar el precio del articulo: ");
            linea = Console.ReadLine();
            precioArticulo = float.Parse(linea);
            Console.Write("Ingrsar cantidad comprada: ");
            linea = Console.ReadLine();
            cantidadComprada = int.Parse(linea);
            precioFinal = precioArticulo * cantidadComprada;
            Console.WriteLine("Deve abonar $"+precioFinal);
            Console.ReadKey();

        }
    }
}
