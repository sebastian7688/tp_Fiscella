using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer13
{
    class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }
        public const double PLUS = 300;

        public Empleado(string nombre, int edad, double salario)
        {
            Nombre = nombre;
            Edad = edad;
            Salario = salario;
        }

        public virtual void Plus()
        {
            if (Edad > 30)
            {
                Salario += PLUS;
            }
        }

        public override string ToString()
        {
            return $"{Nombre}, Edad: {Edad}, Salario: {Salario}";
        }
    }
}
