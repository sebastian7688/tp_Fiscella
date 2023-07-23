using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract07
{
    internal class Program
    {
        //Ingresar el sueldo de una persona, si supera los 3000 pesos mostrar un mensaje en
        //pantalla indicando que debe abonar impuestos.
        static void Main(string[] args)
        {
            int sueldo;
            string linea;
            Console.Write("Ingrese su sueldo: ");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
            if (sueldo > 3000)
            {
                Console.Write("Esta persona deve abonar impuestos");
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("Esta persona no deve abonar impuestos");
                Console.ReadKey();
            }
        }
    }
}
