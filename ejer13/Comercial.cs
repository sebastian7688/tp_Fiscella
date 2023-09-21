using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer13
{
    class Comercial : Empleado
    {
        public double Comision { get; set; }

        public Comercial(string nombre, int edad, double salario, double comision)
            : base(nombre, edad, salario)
        {
            Comision = comision;
        }

        public override void Plus()
        {
            base.Plus();
            if (Comision > 200)
            {
                Salario += PLUS;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Comisión: {Comision}";
        }
    }
}
