using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    class Revolver
    {
        private int posicionActual;
        private int posicionBala;
        private Random random;

        public Revolver()
        {
            random = new Random();
            posicionActual = 0;
            posicionBala = random.Next(1, 7);
        }

        public bool Disparar()
        {
            if (posicionActual == posicionBala)
            {
                Console.WriteLine("¡BANG! La bala ha sido disparada.");
                return true;
            }
            else
            {
                Console.WriteLine("El tambor gira, pero no pasa nada.");
                SiguienteBala();
                return false;
            }
        }

        public void SiguienteBala()
        {
            posicionActual = (posicionActual % 6) + 1;
        }
    }
}
