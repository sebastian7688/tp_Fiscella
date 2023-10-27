using ejer18;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer16
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.CargarPreguntas("preguntas.txt");
            test.RealizarTest();
        }
    }
}
