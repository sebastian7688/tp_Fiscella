using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract23
{
    internal class Program
    {
        //Escribir un programa que solicite ingresar 10 notas de alumnos y
        //nos informe cuántos tienen notas mayores o iguales a 7 y cuántos menores.
        static void Main(string[] args)
        {
            int x=1, aprobados=0, desaprovados=0;
            float nota;
            string linea;
            while (x<11) 
            {
                Console.Write("Ingresse la nota del {0}° Alumno: ",x);
                linea = Console.ReadLine();
                nota = float.Parse(linea);
                x++;
                if (nota >= 7)
                {
                    aprobados++;
                }
                else 
                {
                    desaprovados++;
                }
            }
            Console.WriteLine("Aprobados: "+aprobados);
            Console.WriteLine("Desaprobados: "+ desaprovados);
            Console.ReadKey();
        }
    }
}
