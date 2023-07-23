using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract24
{
    internal class Program
    {
        //Se ingresan un conjunto de n alturas de personas por teclado.
        //Mostrar la altura promedio de las personas.
        static void Main(string[] args)
        {
            int x=0, n;
            float altura, sumaTotal=0, promedio;
            string linea;
            Console.Write("Ingresar la cantidad de personas: ");
            linea=Console.ReadLine();
            n = int.Parse(linea);
            while (x<n) 
            {
                x++;
                Console.Write("Ingrese la altura de {0}° Persona: ",x);
                linea = Console.ReadLine();
                altura = float.Parse(linea);
                sumaTotal = sumaTotal + altura;
            }
            promedio = sumaTotal / n;
            Console.WriteLine("El pomedio de alturas ingresadas es de "+promedio);
            Console.ReadKey();
        }
    }
}
