using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer15
{
    class Almacen
    {
        private List<Producto> productos;

        public Almacen()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            if (!ProductosContienenID(producto.Id))
            {
                productos.Add(producto);
                Console.WriteLine($"Producto '{producto.Nombre}' agregado al almacén.");
            }
            else
            {
                Console.WriteLine($"No se pudo agregar el producto '{producto.Nombre}' al almacén. El ID '{producto.Id}' ya existe.");
            }
        }

        public void EliminarProducto(string id)
        {
            Producto productoEliminar = productos.Find(p => p.Id == id);
            if (productoEliminar != null)
            {
                productos.Remove(productoEliminar);
            }
            else
            {
                Console.WriteLine($"No se encontró ningún producto con el ID '{id}' para eliminar.");
            }
        }

        public double CalcularPrecioTotal()
        {
            double precioTotal = 0.0;
            foreach (Producto producto in productos)
            {
                precioTotal += producto.CalcularPrecio();
            }
            return precioTotal;
        }

        public double CalcularPrecioTotalMarca(string marca)
        {
            double precioTotal = 0.0;
            foreach (Producto producto in productos)
            {
                if (producto is BebidaAzucarada bebida && bebida.Marca == marca)
                {
                    precioTotal += bebida.CalcularPrecio();
                }
            }
            return precioTotal;
        }

        public double CalcularPrecioTotalEstanteria(int estanteria)
        {
            double precioTotal = 0.0;
            foreach (Producto producto in productos)
            {
                if (producto.Estanteria == estanteria)
                {
                    precioTotal += producto.CalcularPrecio();
                }
            }
            return precioTotal;
        }

        public void MostrarInformacion()
        {
            foreach (Producto producto in productos)
            {
                Console.WriteLine(producto.ToString());
            }
        }

        private bool ProductosContienenID(string id)
        {
            return productos.Exists(p => p.Id == id);
        }
    }
}
