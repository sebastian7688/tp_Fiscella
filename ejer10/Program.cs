using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer10
{
    class Program
    {
        static void Main(string[] args)
        {
            Baraja baraja = new Baraja();

            baraja.Barajar();

            Console.WriteLine($"Cartas disponibles en la baraja: {baraja.CartasDisponibles()}");

            List<Carta> mano = baraja.DarCartas(5);

            Console.WriteLine("Cartas en la mano:");
            foreach (Carta carta in mano)
            {
                Console.WriteLine(carta);
            }

            Console.WriteLine($"Cartas disponibles en la baraja después de repartir: {baraja.CartasDisponibles()}");

            List<Carta> monton = baraja.CartasMonton();

            Console.WriteLine("Cartas en el montón:");
            foreach (Carta carta in monton)
            {
                Console.WriteLine(carta);
            }

            Console.WriteLine("Mostrar baraja:");
            baraja.MostrarBaraja();
            Console.ReadKey();
        }
    }
}
