using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pract46
{
    //Se tienen las notas del primer parcial de los alumnos de dos cursos, el curso A y el curso B,
    //cada curso cuenta con 5 alumnos.
    //Realizar un programa que muestre el curso que obtuvo el mayor promedio general.
    class Parcial
    {
        private int[] cursoA;
        private int[] cursoB;
        public void CargaNotas()
        {
            string linea;
            int x = 1;
            cursoA = new int[5];
            cursoB = new int[5];
            Console.WriteLine("Notas del Curso A");
            for (int f =0;f<5;f++)
            {
                Console.Write("Ingrese la Nota del {0}° Alumno: ",x);
                linea = Console.ReadLine();
                cursoA[f] = int.Parse(linea);
                x++;
            }
            x = 1;
            Console.WriteLine();
            Console.WriteLine("Notas del Curso B");
            for (int g=0;g<5;g++) 
            {
                Console.Write("Ingrese la Nota del {0}° Alumno: ",x);
                linea = Console.ReadLine();
                cursoB[g] = int.Parse(linea);
                x++;
            }
        }
        public void MayorPromedio() 
        {
            int suma1=0, suma2=0, promedio1,promedio2;
            for (int f = 0; f < 5; f++)
            {
                suma1 = suma1 + cursoA[f];
            }
            for (int g=0;g<5;g++)
            {
                suma2 = suma2 + cursoB[g];
            }
            promedio1 = suma1 / 5;
            promedio2 = suma2 / 5;
            if (promedio1 > promedio2)
            {
                Console.WriteLine("El curso A saco mayor promedio");
            }
            else 
            {
                Console.WriteLine("El curso B saco mayor promedio");
            }
        }
        static void Main(string[] args)
        {
            Parcial p = new Parcial();
            p.CargaNotas();
            Console.WriteLine();
            p.MayorPromedio();
            Console.ReadKey();
        }
    }
}
