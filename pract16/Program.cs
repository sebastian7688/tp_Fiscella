using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract16
{
    internal class Program
    {
        //Realizar un programa que pida cargar una fecha cualquiera,
        //luego verificar si dicha fecha corresponde a Navidad.
        static void Main(string[] args)
        {
            int dia, mes, año;
            string linea;
            Console.Write("Ingrese el dia: ");
            linea = Console.ReadLine();
            dia = int.Parse(linea);
            Console.Write("Ingrese el mes: ");
            linea = Console.ReadLine();
            mes = int.Parse(linea);
            Console.Write("Ingrese el año: ");
            linea = Console.ReadLine();
            año = int.Parse(linea);
            if (dia == 25 && mes == 12) 
            {
                Console.WriteLine("Es Navidad");
            }
            Console.ReadKey();
        }
    }
}
