using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    class Jugada
    {
        public Jugador Jugador { get; }
        public List<int> Resultados { get; }

        public Jugada(Jugador jugador, List<int> resultados)
        {
            Jugador = jugador;
            Resultados = resultados;
        }
    }
}
