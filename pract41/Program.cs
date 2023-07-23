using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract41
{
    //Confeccionar una clase que represente un empleado.Definir como atributos su nombre y su sueldo.
    //Confeccionar los métodos para la carga, otro para imprimir sus datos y por último
    //uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)
    class Empleado
    {
        private string nombre;
        private float sueldo;

        public void Carga()
        {
            string linea;
            Console.Write("Ingresar el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write("Ingresar el saldo del empleado: ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
            Console.Clear();
        }
        public void Imprimir()
        {
            Console.WriteLine("Nombre del Empleado: " + nombre);
            Console.WriteLine("Sueldo del Empleado: " + sueldo);
        }
        public void PagarImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Deve pagar impuestos");
            }
            else
            {
                Console.WriteLine("No deve pagar impuestos");
            }
        }
        static void Main(string[] args)
        {
            Empleado emple = new Empleado();
            emple.Carga();
            emple.Imprimir();
            emple.PagarImpuestos();
            Console.ReadKey();
        }
    }
}
