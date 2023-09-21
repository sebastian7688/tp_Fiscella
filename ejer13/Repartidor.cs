using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer13
{
    class Repartidor : Empleado
    {
        public string Zona { get; set; }

        public Repartidor(string nombre, int edad, double salario, string zona)
            : base(nombre, edad, salario)
        {
            Zona = zona;
        }

        public override void Plus()
        {
            base.Plus();
            if (Edad < 25 && Zona == "Zona 3")
            {
                Salario += PLUS;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Zona: {Zona}";
        }
    }
}
