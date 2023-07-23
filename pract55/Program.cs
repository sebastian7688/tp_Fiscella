using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace pract55
{
    //Se desea saber la temperatura media trimestral de cuatro paises.
    //Para ello se tiene como dato las temperaturas medias mensuales de dichos paises.
    //Se debe ingresar el nombre del país y seguidamente las tres temperaturas medias mensuales.
    //Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en memoria.
    //a - Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
    //b - Imprimir los nombres de las paises y las temperaturas medias mensuales de las mismas.
    //c - Calcular la temperatura media trimestral de cada país.
    //d - Imprimir los nombres de los paises y las temperaturas medias trimestrales.
    //e - Imprimir el nombre del país con la temperatura media trimestral mayor.
    class Paises
    {
        private string[] nombre;
        private int[,] temperaturaMensual;
        private int[] temperaturaTrimestral;
        public void Carga()
        {
            string linea;
            nombre = new string[4];
            temperaturaMensual = new int[4, 3];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese el nombre del pais: ");
                nombre[i] = Console.ReadLine();
                for (int f = 0; f < 3; f++)
                {
                    Console.Write("Ingrese la temperatura del {0}° mes: ", f + 1);
                    linea = Console.ReadLine();
                    temperaturaMensual[i, f] = int.Parse(linea);
                }
            }
        }
        public void Trimestral()
        {
            temperaturaTrimestral = new int[4];
            int promedio;
            for (int f = 0; f < 4; f++)
            {
                int suma = 0;
                for (int i = 0; i < 3; i++)
                {
                    suma = suma + temperaturaMensual[f, i];
                }
                promedio=suma/temperaturaMensual.GetLength(1);
                temperaturaTrimestral[f] = promedio;
            }
        }
        public void TemperaturaTrimestralMayor()
        {
            int help = temperaturaTrimestral[0], pos = 0;
            for (int f = 1; f < 4; f++)
            {
                if (temperaturaTrimestral[f] > help)
                {
                    help = temperaturaTrimestral[f];
                    pos = f;
                }
            }
            Console.WriteLine("Nombre del pais: " + nombre[pos]);
            Console.WriteLine("Temperatura: " + help);
        }
        public void ImprimirPaisTemperaturaMensuual()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Nombre del pais: " + nombre[i]);
                Console.WriteLine("Temperaturas:");
                for (int f = 0; f < 3; f++)
                {
                    Console.Write(temperaturaMensual[i, f] + "°  ");
                }
                Console.WriteLine();
            }

        }
        public void ImprimirPaisTemperaturaTrimestral()
        {
            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine("Nombre del pais: " + nombre[f]);
                Console.WriteLine("Temperatura Trimestral: " + temperaturaTrimestral[f]);
            }
        }
        static void Main(string[]args)
        {
            Paises p = new Paises();
            Console.WriteLine("Carga de informacion de cada Pais" +
                "");
            p.Carga();
            Console.WriteLine();
            Console.WriteLine("Pais y sus temperaturas de tres meses");
            p.ImprimirPaisTemperaturaMensuual();
            p.Trimestral();
            Console.WriteLine();
            Console.WriteLine("Pais y su temperatura media trimestral");
            p.ImprimirPaisTemperaturaTrimestral();
            Console.WriteLine();
            Console.WriteLine("El pais con mayor temperatura media");
            p.TemperaturaTrimestralMayor();
            Console.ReadKey();
        }
    }
}
