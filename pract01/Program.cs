using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            float pagoHora;
            float sueldo;
            string linea;
            Console.WriteLine("Ingrese las horas trabajadas por el operario:");
            linea = Console.ReadLine();
            horasTrabajadas = int.Parse(linea);
            Console.WriteLine("Ingrese el pago por hora del operasrio;");
            linea = Console.ReadLine();
            pagoHora = float.Parse(linea);
            sueldo = horasTrabajadas * pagoHora;
            Console.WriteLine("El sueldo mensual del operario es $" + sueldo);
            Console.ReadKey();
        }
    }
}
