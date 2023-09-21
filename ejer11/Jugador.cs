using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    class Jugador
    {
        public string Nombre { get; }
        public int Dinero { get; set; }
        public int Victorias { get; set; }

        public Jugador(string nombre, int dineroInicial)
        {
            Nombre = nombre;
            Dinero = dineroInicial;
            Victorias = 0;
        }

        public void GanarPozo(int pozo)
        {
            Dinero += pozo;
            Victorias++;
        }
    }

}
