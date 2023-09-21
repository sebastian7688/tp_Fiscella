using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego de la ruleta rusa.");
            Console.Write("Ingrese el número de jugadores (entre 1 y 6): ");
            int numJugadores = LeerEntero(1, 6);

            Juego juego = new Juego(numJugadores);
            juego.IniciarJuego();

            Console.WriteLine("\nFin del juego.");
            Console.ReadKey();
        }
        static int LeerEntero(int min, int max)
        {
            int valor;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out valor) && valor >= min && valor <= max)
                {
                    return valor;
                }
                Console.Write("Entrada inválida. Ingrese un número entre " + min + " y " + max + ": ");
            }
        }
    }  
}
