using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer14
{
    class Perecedero : Producto
    {
        public int DiasCaducar { get; set; }

        public Perecedero(string nombre, double precio, int diasCaducar)
            : base(nombre, precio)
        {
            DiasCaducar = diasCaducar;
        }

        public override double Calcular(int cantidad)
        {
            double precio = base.Calcular(cantidad);

            if (DiasCaducar == 1)
            {
                return precio / 4;
            }
            else if (DiasCaducar == 2)
            {
                return precio / 3;
            }
            else if (DiasCaducar == 3)
            {
                return precio / 2;
            }

            return precio;
        }

        public override string ToString()
        {
            return base.ToString() + $", Días a caducar: {DiasCaducar}";
        }
    }
}
