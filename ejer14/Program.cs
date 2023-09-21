using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer14
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto[] productos = new Producto[6];

            productos[0] = new Producto("Producto A", 10.0);
            productos[1] = new Producto("Producto B", 15.0);
            productos[2] = new Producto("Producto C", 5.0);
            productos[3] = new Perecedero("Perecedero A", 8.0, 1);
            productos[4] = new Perecedero("Perecedero B", 12.0, 3);
            productos[5] = new NoPerecedero("No Perecedero A", 20.0, "Tipo X");

            CalcularPrecioTotal(productos, 5);

            Console.ReadLine();
        }
        static void CalcularPrecioTotal(Producto[] productos, int cantidad)
        {
            double precioTotal = 0.0;

            foreach (Producto producto in productos)
            {
                precioTotal += producto.Calcular(cantidad);
            }

            Console.WriteLine($"Precio total por vender {cantidad} productos de cada tipo: {precioTotal} euros.");
        }
    }
}
