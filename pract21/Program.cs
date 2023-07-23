using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract21
{
    internal class Program
    {
        //De un operario se conoce su sueldo y los años de antigüedad.Se pide confeccionar
        //un programa que lea los datos de entrada e informe:
        //a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años,
        //otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
        //b)Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años,
        //otorgarle un aumento de 5 %.
        //c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.
        static void Main(string[] args)
        {
            float sueldo, bono1, bono2;
            int antiguedad;
            string linea;
            Console.Write("Ingrese sueldo del operario: ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
            Console.Write("Ingrese Los años de antiguedad: ");
            linea = Console.ReadLine();
            antiguedad = int.Parse(linea);
            bono1 = 20 * sueldo / 100;
            bono2 = 5 * sueldo / 100;
            if (sueldo < 500 && antiguedad >= 10)
            {
                sueldo = sueldo + bono1;
                Console.WriteLine("Sueldo: " + sueldo);
            }
            else if (sueldo < 500 && antiguedad < 10)
            {
                sueldo = sueldo + bono2;
                Console.WriteLine("Sueldo: " + sueldo);
            }
            else if (sueldo>=500)
            {
                Console.WriteLine("Sueldo: "+sueldo);
            }
            Console.ReadKey();
        }
    }
}
