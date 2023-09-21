using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer14
{
    class NoPerecedero : Producto
    {
        public string Tipo { get; set; }

        public NoPerecedero(string nombre, double precio, string tipo)
            : base(nombre, precio)
        {
            Tipo = tipo;
        }
    }
}
