using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer14
{
    class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public virtual double Calcular(int cantidad)
        {
            return Precio * cantidad;
        }

        public override string ToString()
        {
            return $"{Nombre}, Precio: {Precio}";
        }
    }
}
