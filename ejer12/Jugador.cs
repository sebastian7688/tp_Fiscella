using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    class Jugador
    {
        public int Id { get; }
        public string Nombre { get; }
        public bool Vivo { get; set; }

        public Jugador(int id)
        {
            Id = id;
            Nombre = "Jugador " + id;
            Vivo = true;
        }

        public void Disparar(Revolver revolver)
        {
            Console.WriteLine(Nombre + " se apunta y dispara...");
            if (revolver.Disparar())
            {
                Vivo = false;
                Console.WriteLine(Nombre + " ha muerto.");
            }
            else
            {
                Console.WriteLine(Nombre + " ha sobrevivido.");
            }
        }
    }
}
