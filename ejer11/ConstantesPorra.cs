using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    class ConstantesPorra : IConstantes
    {
        public int DineroInicial => 10;
        public int Jornadas => 5; 
        public int PartidosPorJornada => 3; 
        public int AciertosNecesarios => 2;
    }
}
