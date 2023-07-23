using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract10
{
    internal class Program
    {
        //Se ingresan tres notas de un alumno, si el promedio es mayor o igual a siete
        //mostrar un mensaje "Promocionado".

        static void Main(string[] args)
        {
            float nota1, nota2, nota3, sumaTotal, promedio;
            string linea;
            Console.Write("Ingrese la primera nota: ");
            linea=Console.ReadLine();
            nota1 = float.Parse(linea);
            Console.Write("Ingrese la segunda nota:");
            linea = Console.ReadLine();
            nota2 = float.Parse(linea);
            Console.Write("Ingrese la tercera nota: ");
            linea = Console.ReadLine();
            nota3 = float.Parse(linea);
            sumaTotal = nota1 + nota2 + nota3;
            promedio = sumaTotal / 3;
            if (promedio >= 7)
            {
                Console.WriteLine("Promocionado :) \nNota final: "+promedio);
            }
            else 
            {
                Console.WriteLine("No Promocionado :( \nNota Final: "+promedio);
            }
            Console.ReadKey();
        }
    }
}
