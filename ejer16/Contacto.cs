using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer16
{
    class Contacto
    {
        public string Nombre { get; }
        public string Telefono { get; }

        public Contacto(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }

        public override bool Equals(object obj)
        {
            if (obj is Contacto otroContacto)
            {
                return Nombre.Equals(otroContacto.Nombre);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Nombre.GetHashCode();
        }
    }
}
