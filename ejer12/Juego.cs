using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    class Juego
    {
        private List<Jugador> jugadores;
        private Revolver revolver;

        public Juego(int numJugadores)
        {
            jugadores = new List<Jugador>();
            for (int i = 1; i <= numJugadores; i++)
            {
                jugadores.Add(new Jugador(i));
            }
            revolver = new Revolver();
        }
        public void IniciarJuego()
        {
            while (true)
            {
                foreach (Jugador jugador in jugadores)
                {
                    if (jugador.Vivo)
                    {
                        Console.WriteLine("\nTurno de " + jugador.Nombre);
                        jugador.Disparar(revolver);
                        if (!jugador.Vivo)
                        {
                            if (FinJuego())
                                return;
                        }
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ReadLine();
                    }
                }
            }
        }
        public bool FinJuego()
        {
            foreach (Jugador jugador in jugadores)
            {
                if (jugador.Vivo)
                {
                    return false;
                }
            }
            Console.WriteLine("\nTodos los jugadores han muerto. El juego ha terminado.");
            return true;
        }
    }
}
