using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace pract15
{
    internal class Program
    {
        //Un postulante a un empleo, realiza un test de capacitación, se obtuvo
        //la siguiente información: cantidad total de preguntas que se le realizaron y
        //la cantidad de preguntas que contestó correctamente.Se pide confeccionar un
        //programa que ingrese los dos datos por teclado e informe el nivel del mismo
        //según el porcentaje de respuestas correctas que ha obtenido, y sabiendo que:

        //Nivel máximo:	Porcentaje>=90%.
        //Nivel medio:	Porcentaje>=75% y<90%.
        //Nivel regular:	Porcentaje>=50% y<75%.
        //Fuera de nivel:	Porcentaje<50%.
        static void Main(string[] args)
        {
            int cantidadPregunta, preguntasCorrectas, porsentaje;
            string linea;
            Console.Write("Ingrese la cantidad de Preguntas del tets: ");
            linea = Console.ReadLine();
            cantidadPregunta = int.Parse(linea);
            Console.Write("Ingrese la cantidad de Preguntas contestadas correctamente: ");
            linea = Console.ReadLine();
            preguntasCorrectas = int.Parse(linea);
            porsentaje = preguntasCorrectas * 100 / cantidadPregunta;
            Console.Clear();
            if (porsentaje < 50)
            {
                Console.WriteLine("Fuera de Nivel \nNota del test: "+porsentaje+"%");
            }
            else if (porsentaje >= 50 && porsentaje < 75)
            {
                Console.WriteLine("Nivel Regular \nNota del test: "+porsentaje + "%");
            }
            else if (porsentaje >= 75 && porsentaje < 90)
            {
                Console.WriteLine("Nivel Medio \nNota del test: " + porsentaje + "%");
            }
            else
            {
                Console.WriteLine("Nivel Maximo \nNota del test: "+porsentaje + "%");
            }
            Console.ReadKey();
        }
    }
}
