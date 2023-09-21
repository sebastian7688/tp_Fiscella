using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer10
{
    class Carta
    {
        public int Numero { get; }
        public string Palo { get; }

        public Carta(int numero, string palo)
        {
            Numero = numero;
            Palo = palo;
        }

        public override string ToString()
        {
            return $"{Numero} de {Palo}";
        }
    }
}
