using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer16
{
    class AgendaTelefonica
    {
        private List<Contacto> contactos;
        private int capacidadMaxima;

        public AgendaTelefonica(int capacidadMaxima = 10)
        {
            contactos = new List<Contacto>();
            this.capacidadMaxima = capacidadMaxima;
        }

        public bool AniadirContacto(Contacto contacto)
        {
            if (contactos.Count >= capacidadMaxima || ExisteContacto(contacto))
            {
                return false;
            }
            contactos.Add(contacto);
            return true;
        }

        public bool ExisteContacto(Contacto contacto)
        {
            return contactos.Contains(contacto);
        }

        public void ListarContactos()
        {
            foreach (Contacto contacto in contactos)
            {
                Console.WriteLine($"Nombre: {contacto.Nombre}, Teléfono: {contacto.Telefono}");
            }
        }

        public Contacto BuscaContacto(string nombre)
        {
            return contactos.Find(c => c.Nombre.Equals(nombre));
        }

        public bool EliminarContacto(Contacto contacto)
        {
            return contactos.Remove(contacto);
        }

        public bool AgendaLlena()
        {
            return contactos.Count >= capacidadMaxima;
        }

        public int HuecosLibres()
        {
            return capacidadMaxima - contactos.Count;
        }
    }
}
