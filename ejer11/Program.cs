using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    class Program
    {
        static void Main(string[] args)
        {
            Porra porra = new Porra();

            for (int jornada = 1; jornada <= porra.Constantes.Jornadas; jornada++)
            {
                Console.WriteLine($"Jornada {jornada}:");
                porra.RealizarApuestas(jornada);
                porra.VerificarAciertos(jornada);
                porra.MostrarResultados();
            }

            Console.WriteLine("\nResultados finales:");
            porra.MostrarDineroYVictorias();
            Console.ReadKey();
        }
    }
}
