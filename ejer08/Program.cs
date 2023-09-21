using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ejer08
{
//Queremos representar con programación orientada a objetos, un aula con estudiantes y
//un profesor.
//Tanto de los estudiantes como de los profesores necesitamos saber su nombre, edad y sexo.
//De los estudiantes, queremos saber también su calificación actual (entre 0 y 10)
//y del profesor que materia da.
//Las materias disponibles son matemáticas, filosofía y física.
//Los estudiantes tendrán un 50% para no ir a clase, por lo que sí hacen faltazo no van a clase pero aunque no vayan quedará registrado en el aula (como que cada uno tiene su sitio).
//El profesor tiene un 20% de no encontrarse disponible(reuniones, baja, etc.)
//Las dos operaciones anteriores deben llamarse igual en Estudiante y Profesor(polimorfismo).
//El aula debe tener un identificador numérico, el número máximo de estudiantes y para que está destinada(matemáticas, filosofía o física). Piensa que más atributos necesita.
//Un aula para que se pueda dar clase necesita que el profesor esté disponible, que el profesor de la materia correspondiente esté en el aula correspondiente(un profesor de filosofía no puede dar en un aula de matemáticas) y que haya más del 50% de alumnos.
//El objetivo es crear un aula de alumnos y un profesor y determinar si puede darse clase, teniendo en cuenta las condiciones antes dichas.
//Si se puede dar clase mostrar cuántos alumnos y alumnas (por separado) están aprobados de momento (imaginad que les están entregando las notas).
//NOTA: Los datos pueden ser aleatorios(nombres, edad, calificaciones, etc.) siempre y cuando tengan sentido(edad no puede ser 80 en un estudiante o calificación ser 12).

    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }

        public Persona(string nombre, int edad, char sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
        }
    }

    class Estudiante : Persona
    {
        public double Calificacion { get; set; }

        public Estudiante(string nombre, int edad, char sexo, double calificacion)
            : base(nombre, edad, sexo)
        {
            Calificacion = calificacion;
        }

        public bool FaltaClase()
        {
            Random random = new Random();
            return random.NextDouble() < 0.5;
        }

        public bool EstaAprobado()
        {
            return Calificacion >= 5.0;
        }
    }

    class Profesor : Persona
    {
        public string Materia { get; set; }

        public Profesor(string nombre, int edad, char sexo, string materia)
            : base(nombre, edad, sexo)
        {
            Materia = materia;
        }

        public bool Disponible()
        {
            Random random = new Random();
            return random.NextDouble() > 0.2;
        }
    }

    class Aula
    {
        public int Identificador { get; set; }
        public int CapacidadMaxima { get; set; }
        public string Materia { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public Profesor Profesor { get; set; }

        public Aula(int identificador, int capacidadMaxima, string materia, Profesor profesor)
        {
            Identificador = identificador;
            CapacidadMaxima = capacidadMaxima;
            Materia = materia;
            Estudiantes = new List<Estudiante>();
            Profesor = profesor;
        }

        public bool SePuedeDarClase()
        {
            if (Profesor.Disponible() && Profesor.Materia == Materia && Estudiantes.Count >= CapacidadMaxima * 0.5)
            {
                return true;
            }
            return false;
        }

        public int EstudiantesAprobados()
        {
            return Estudiantes.FindAll(estudiante => estudiante.EstaAprobado()).Count;
        }

        public int EstudiantesAprobadas()
        {
            return Estudiantes.FindAll(estudiante => estudiante.Sexo == 'F' && estudiante.EstaAprobado()).Count;
        }
    }

    class Program
    {
        static void Main()
        {
            // Crear un profesor
            Profesor profesor = new Profesor("Profesor1", 35, 'M', "Matemáticas");

            // Crear estudiantes
            Estudiante estudiante1 = new Estudiante("Estudiante1", 20, 'M', 7.5);
            Estudiante estudiante2 = new Estudiante("Estudiante2", 21, 'F', 6.0);
            Estudiante estudiante3 = new Estudiante("Estudiante3", 19, 'M', 4.0);
            Estudiante estudiante4 = new Estudiante("Estudiante4", 22, 'F', 8.5);

            // Crear un aula
            Aula aula = new Aula(1, 30, "Matemáticas", profesor);

            // Agregar estudiantes al aula
            aula.Estudiantes.Add(estudiante1);
            aula.Estudiantes.Add(estudiante2);
            aula.Estudiantes.Add(estudiante3);
            aula.Estudiantes.Add(estudiante4);

            // Verificar si se puede dar clase
            if (aula.SePuedeDarClase())
            {
                Console.WriteLine("Se puede dar clase en el aula.");
                Console.WriteLine($"Número de estudiantes aprobados: {aula.EstudiantesAprobados()}");
                Console.WriteLine($"Número de estudiantes aprobadas: {aula.EstudiantesAprobadas()}");
            }
            else
            {
                Console.WriteLine("No se puede dar clase en el aula debido a las condiciones.");
            }
            Console.ReadKey();
        }
    }
}