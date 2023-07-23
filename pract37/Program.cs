using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract37
{
    internal class Program
    {
        //Se cuenta con la siguiente información:
        //Las edades de 50 estudiantes del turno mañana.
        //Las edades de 60 estudiantes del turno tarde.
        //Las edades de 110 estudiantes del turno noche.
        //Las edades de cada estudiante deben ingresarse por teclado.
        //a) Obtener el promedio de las edades de cada turno(tres promedios)
        //b) Imprimir dichos promedios(promedio de cada turno)
        //c) Mostrar por pantalla un mensaje que indique cual de los tres turnos tiene un promedio de edades menor.
        static void Main(string[] args)
        {
            int edadAlumno1, edadAlumno2, edadAlumno3, sumaEdad1 = 0, sumaEdad2 = 0, sumaEdad3 = 0;
            float promedio1, promedio2, promedio3;
            string linea;
            for (int f = 1; f <= 50; f++)
            {
                Console.Write("Ingresar la edad del {0}° Alumno del Turno Mañana: ", f);
                linea = Console.ReadLine();
                edadAlumno1 = int.Parse(linea);
                sumaEdad1 = sumaEdad1 + edadAlumno1;
            }
            promedio1 = sumaEdad1 / 50;
            Console.WriteLine();
            for (int g = 1; g <= 60; g++)
            {
                Console.Write("Ingresar la edad del {0}° Alumno del Turno Tarde: ", g);
                linea = Console.ReadLine();
                edadAlumno2 = int.Parse(linea);
                sumaEdad2 = sumaEdad2 + edadAlumno2;
            }
            promedio2 = sumaEdad2 / 60;
            Console.WriteLine();
            for (int h = 1; h <= 110; h++)
            {
                Console.Write("Ingresar la edad del {0}° Alumno del Turno Noche: ", h);
                linea = Console.ReadLine();
                edadAlumno3 = int.Parse(linea);
                sumaEdad3 = sumaEdad3 + edadAlumno3;
            }
            promedio3 = sumaEdad3 / 110;
            Console.WriteLine();
            Console.WriteLine("El promedio de edades del Turno Mañana es " + promedio1);
            Console.WriteLine("El promedio de edades del Turno Tarde es " + promedio2);
            Console.WriteLine("El promedio de edades del Turno Noche es " + promedio3);
            if (promedio1 < promedio2 && promedio1 < promedio3)
            {
                Console.WriteLine("El turno que tiene menor promedio de edades es la Mañana");
            }
            else if (promedio2 < promedio1 && promedio2 < promedio3)
            {
                Console.WriteLine("El turno que tiene menor promedio de edades es la Tarde");
            }
            else 
            {
                Console.WriteLine("El turno que tiene menor promedio de edades es la Noche");
            }
            Console.ReadKey();
        

        }
    }
}
