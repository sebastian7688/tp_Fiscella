using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ejer18
{
    class Program
    {
        static void Main()
        {
            Test test = new Test();
            test.CargarPreguntas("preguntas.txt"); 
            test.RealizarTest();
            Console.ReadKey();
        }
    }

}
