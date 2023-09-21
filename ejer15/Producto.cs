using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer15
{
    class Producto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public double Litros { get; set; }
        public double Precio { get; set; }
        public int Estanteria { get; set; }

        public Producto(string id, string nombre, double litros, double precio)
        {
            Id = id;
            Nombre = nombre;
            Litros = litros;
            Precio = precio;
        }

        public virtual double CalcularPrecio()
        {
            return Precio;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Litros: {Litros}L, Precio: {Precio:C}";
        }
    }
}
