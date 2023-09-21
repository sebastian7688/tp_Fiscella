using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer15
{
    class Program
    {
        static void Main(string[] args)
        {
            Almacen almacen = new Almacen();
            almacen.AgregarProducto(new AguaMineral("001", "Agua Natural", 1.5, 1.0, "Manantial A"));
            almacen.AgregarProducto(new BebidaAzucarada("002", "Coca-Cola", 2.0, 1.5, "Coca-Cola Company", 10, true));
            almacen.AgregarProducto(new BebidaAzucarada("003", "Fanta", 2.0, 1.5, "Coca-Cola Company", 12, false));
            Console.WriteLine("Información del Almacén:");
            almacen.MostrarInformacion();
            double precioTotalAlmacen = almacen.CalcularPrecioTotal();
            Console.WriteLine($"Precio total de todas las bebidas en el almacén: {precioTotalAlmacen:C}");
            string marca = "Coca-Cola Company";
            double precioTotalMarca = almacen.CalcularPrecioTotalMarca(marca);
            Console.WriteLine($"Precio total de las bebidas de la marca '{marca}': {precioTotalMarca:C}");
            int estanteria = 1;
            double precioTotalEstanteria = almacen.CalcularPrecioTotalEstanteria(estanteria);
            Console.WriteLine($"Precio total de las bebidas en la estantería {estanteria}: {precioTotalEstanteria:C}");
            string idEliminar = "002";
            almacen.EliminarProducto(idEliminar);
            Console.WriteLine($"Producto con ID '{idEliminar}' eliminado del almacén.");
            Console.WriteLine("Información del Almacén después de eliminar un producto:");
            almacen.MostrarInformacion();
            Console.ReadKey();
        }
    }
}
