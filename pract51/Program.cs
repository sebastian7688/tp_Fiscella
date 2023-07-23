using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pract51
{
    //Cargar en un vector los nombres de 5 paises y en otro vector
    //paralelo la cantidad de habitantes del mismo.
    //Ordenar alfabéticamente e imprimir los resultados.
    //Por último ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir nuevamente.
    class Paises
    {
        private string[] nombre;
        private int[] habitantes;
        public void CargaInfoPais()
        {
            string linea;
            nombre = new string[5];
            habitantes = new int[5];
            for (int f = 0; f < habitantes.Length; f++)
            {
                Console.Write("Ingrese el nombre del pais: ");
                nombre[f] = Console.ReadLine();
                Console.Write("Ingrese la cantidad de habitantes: ");
                linea = Console.ReadLine();
                habitantes[f] = int.Parse(linea);

            }
        }
        public void Imprimir()
        {
            for (int f = 0; f < nombre.Length; f++)
            {
                Console.WriteLine("Nombre del Pais: {0}; Cantidad de habitantes: {1}", nombre[f], habitantes[f]);
            }
        }
        public void OrdenarNombrePais()
        {
            string help1;
            int help2;
            for (int i = 0; i < nombre.Length; i++)
            {
                for (int f = 0; f < nombre.Length - 1 - i; f++)
                {
                    if (nombre[f].CompareTo(nombre[f + 1]) > 0)
                    {
                        help1 = nombre[f];
                        nombre[f] = nombre[f + 1];
                        nombre[f + 1] = help1;
                        help2 = habitantes[f];
                        habitantes[f] = habitantes[f + 1];
                        habitantes[f + 1] = help2;
                    }
                }
            }
        }
        public void OrdenarCantHabPais()
        {
            string help;
            int help2;
            for (int k = 0; k < nombre.Length; k++)
            {
                for (int f = 0; f < nombre.Length - 1 - k; f++)
                {
                    if (habitantes[f] < habitantes[f + 1])
                    {
                        help2 = habitantes[f];
                        habitantes[f] = habitantes[f + 1];
                        habitantes[f + 1] = help2;
                        help = nombre[f];
                        nombre[f] = nombre[f + 1];
                        nombre[f + 1] = help;
                    }
                }
            }
        }
        static void Main(string[] args) 
        {
            Paises p = new Paises();
            Console.WriteLine("Ingresar datos de 5 Paises");
            p.CargaInfoPais();
            Console.WriteLine();
            Console.WriteLine("Ordenar alfabeticamente Los nombres del pais");
            p.OrdenarNombrePais();
            p.Imprimir();
            Console.WriteLine();
            Console.WriteLine("Ordenar de mayor a menor la cantidad de habitantes");
            p.OrdenarCantHabPais();
            p.Imprimir();
            Console.ReadLine();


        }
    }
}
