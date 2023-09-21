using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer13
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Comercial comercial1 = new Comercial("Comercial 1", 35, 1500, 300);
            Comercial comercial2 = new Comercial("Comercial 2", 25, 2500, 250);
            Repartidor repartidor1 = new Repartidor("Repartidor 1", 22, 1200, "Zona 3");
            Repartidor repartidor2 = new Repartidor("Repartidor 2", 28, 1800, "Zona 2");

            AplicarPlus(comercial1);
            AplicarPlus(comercial2);
            AplicarPlus(repartidor1);
            AplicarPlus(repartidor2);

            Console.WriteLine("Empleados después de aplicar el plus:");
            Console.WriteLine(comercial1);
            Console.WriteLine(comercial2);
            Console.WriteLine(repartidor1);
            Console.WriteLine(repartidor2);
            Console.ReadKey();
        }

        static void AplicarPlus(Empleado empleado)
        {
            empleado.Plus();
        }

    }
}
