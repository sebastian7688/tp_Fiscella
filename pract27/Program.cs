using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace pract27
{
    internal class Program
    {
        //Mostrar los múltiplos de 8 hasta el valor 500. Debe aparecer en pantalla 8 - 16 - 24, etc.
        static void Main(string[] args)
        {
            int  multiplos8 = 8;
            while (multiplos8<500)
            {
                Console.Write(multiplos8);
                multiplos8 = multiplos8 + 8;
                Console.Write(" - ");
                
            }
            Console.ReadKey();
        }
    }
}
