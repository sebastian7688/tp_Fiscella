using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer10
{
    class Baraja
    {
        private List<Carta> cartas;
        private List<Carta> monton;
        private Random random;

        public Baraja()
        {
            cartas = new List<Carta>();
            monton = new List<Carta>();
            random = new Random();

            string[] palos = { "Espadas", "Bastos", "Oros", "Copas" };

            foreach (string palo in palos)
            {
                for (int numero = 1; numero <= 12; numero++)
                {
                    if (numero != 8 && numero != 9)
                    {
                        cartas.Add(new Carta(numero, palo));
                    }
                }
            }
        }

        public void Barajar()
        {
            for (int i = cartas.Count - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                Carta temp = cartas[i];
                cartas[i] = cartas[j];
                cartas[j] = temp;
            }
        }

        public Carta SiguienteCarta()
        {
            if (cartas.Count > 0)
            {
                Carta carta = cartas[0];
                cartas.RemoveAt(0);
                monton.Add(carta);
                return carta;
            }
            else
            {
                Console.WriteLine("No hay más cartas en la baraja.");
                return null;
            }
        }

        public int CartasDisponibles()
        {
            return cartas.Count;
        }

        public List<Carta> DarCartas(int cantidad)
        {
            List<Carta> mano = new List<Carta>();

            for (int i = 0; i < cantidad; i++)
            {
                Carta carta = SiguienteCarta();
                if (carta != null)
                {
                    mano.Add(carta);
                }
                else
                {
                    Console.WriteLine("No hay suficientes cartas para repartir.");
                    break;
                }
            }

            return mano;
        }

        public List<Carta> CartasMonton()
        {
            return monton;
        }

        public void MostrarBaraja()
        {
            foreach (Carta carta in cartas)
            {
                Console.WriteLine(carta);
            }
        }
    }
}
