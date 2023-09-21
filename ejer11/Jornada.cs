using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    class Jornada
    {
        public int Numero { get; }
        public int Partidos { get; }
        public List<Jugada> Jugadas { get; }
        public int Pozo { get; set; }

        public Jornada(int numero, int partidos)
        {
            Numero = numero;
            Partidos = partidos;
            Jugadas = new List<Jugada>();
            Pozo = 0;
        }

        public void Apostar(Jugador jugador, List<int> resultados)
        {
            Jugadas.Add(new Jugada(jugador, resultados));
            jugador.Dinero -= 1; 
            Pozo += 1; 
        }

        public int VerificarAciertos(Jugador jugador)
        {
            Jugada jugada = Jugadas.FirstOrDefault(j => j.Jugador == jugador);

            if (jugada != null)
            {
                int aciertos = 0;
                foreach (int resultado in jugada.Resultados)
                {
                    if (resultado == 2) 
                    {
                        aciertos++;
                    }
                }
                return aciertos;
            }

            return 0;
        }

        public override string ToString()
        {
            return $"Jornada {Numero}: Pozo = {Pozo}";
        }
    }

}
