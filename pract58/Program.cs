using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract58
{
    //Confeccionar una clase que represente un empleado.Definir como atributos su nombre y su sueldo.
    //En el constructor cargar los atributos y luego en otro método imprimir sus datos y
    //por último uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)
    class Empleado
    {
        private string nombre;
        private int sueldo;
        public Empleado() 
        {
            string linea;
            Console.Write("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el sueldo del empleado: ");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }
        public void Imprimir() 
        {
            Console.WriteLine("Nombre del Empleado: {0}\nSueldo: {1}",nombre,sueldo);
        }
        public void PagaImpuesto() 
        {
            if (sueldo > 3000)
            {
                Console.Write("Deve pagar impuestos");
            }
            else
            {
                Console.WriteLine("No deve pagar impuestos");
            }
        }
        static void Main(string[] args)
        {
            Empleado e = new Empleado();
            Console.WriteLine();
            e.Imprimir();
            Console.WriteLine();
            e.PagaImpuesto();
            Console.ReadKey();
        }
    }
}
