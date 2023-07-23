using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract25
{
    internal class Program
    {
        //En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500,
        //realizar un programa que lea los sueldos que cobra cada empleado e informe cuántos
        //empleados cobran entre $100 y $300 y cuántos cobran más de $300.
        //Además el programa deberá informar el importe que gasta la empresa en sueldos al personal.
        static void Main(string[] args)
        {
            int x=0, n, sueldo, sueldosPersonal=0, sueldosMenores=0, sueldosMayores=0;
            string linea;
            Console.Write("Ingrese la cantidad de empleados de la empresa: ");
            linea = Console.ReadLine();
            n= int.Parse(linea);
            while (x<n) 
            {
                x++;
                Console.Write("Ingrese el sueldo del {0}° Empleado: ",x);
                linea = Console.ReadLine();
                sueldo = int.Parse(linea);
                if (sueldo >= 100 && sueldo <= 500)
                {
                    sueldosPersonal = sueldosPersonal + sueldo;
                    if (sueldo >= 100 && sueldo <= 300)
                    {
                        sueldosMenores++;
                    }
                    else if (sueldo > 300)
                    {
                        sueldosMayores++;
                    }
                }
                else 
                {
                    Console.WriteLine("Sueldo no correspondiente");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Empleados que cobran entre $100 y $300: "+ sueldosMenores);
            Console.WriteLine("Empleados que cobran mas de $300: "+ sueldosMayores);
            Console.WriteLine("La empresa gasta en sueldos del personal $"+ sueldosPersonal);
            Console.ReadLine();
        }
    }
}
