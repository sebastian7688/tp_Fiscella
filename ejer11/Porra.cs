using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    class Porra
    {
        private List<Jugador> jugadores;
        private List<Jornada> jornadas;
        public IConstantes Constantes { get; }

        public Porra()
        {
            Constantes = new ConstantesPorra();
            jugadores = new List<Jugador>
        {
            new Jugador("Jugador 1", Constantes.DineroInicial),
            new Jugador("Jugador 2", Constantes.DineroInicial),
            new Jugador("Jugador 3", Constantes.DineroInicial)
        };
            jornadas = new List<Jornada>();
        }

        public void RealizarApuestas(int jornada)
        {
            Jornada nuevaJornada = new Jornada(jornada, Constantes.PartidosPorJornada);
            jornadas.Add(nuevaJornada);

            foreach (Jugador jugador in jugadores)
            {
                if (jugador.Dinero >= Constantes.DineroInicial)
                {
                    List<int> resultados = GenerarResultadosAleatorios(Constantes.PartidosPorJornada);
                    nuevaJornada.Apostar(jugador, resultados);
                }
            }
        }

        public void VerificarAciertos(int jornada)
        {
            Jornada jornadaActual = jornadas.FirstOrDefault(j => j.Numero == jornada);

            if (jornadaActual != null)
            {
                foreach (Jugador jugador in jugadores)
                {
                    if (jugador.Dinero >= Constantes.DineroInicial)
                    {
                        int aciertos = jornadaActual.VerificarAciertos(jugador);
                        if (aciertos >= Constantes.AciertosNecesarios)
                        {
                            jugador.GanarPozo(jornadaActual.Pozo);
                            jornadaActual.Pozo = 0;
                        }
                    }
                }
            }
        }

        public void MostrarResultados()
        {
            foreach (Jornada jornada in jornadas)
            {
                Console.WriteLine(jornada);
            }
        }

        public void MostrarDineroYVictorias()
        {
            foreach (Jugador jugador in jugadores)
            {
                Console.WriteLine($"{jugador.Nombre}: Dinero = {jugador.Dinero}, Victorias = {jugador.Victorias}");
            }
        }

        private List<int> GenerarResultadosAleatorios(int cantidad)
        {
            Random random = new Random();
            List<int> resultados = new List<int>();

            for (int i = 0; i < cantidad; i++)
            {
                resultados.Add(random.Next(0, 3)); 
            }

            return resultados;
        }
    }
}
