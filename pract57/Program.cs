using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract57
{
    //Confeccionar una clase para administrar los días que han faltado los 3 empleados de una empresa.
    //Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz irregular
    //para cargar los días que han faltado cada empleado (cargar el número de día que faltó)
    //Cada fila de la matriz representan los días de cada empleado.
    //Mostrar los empleados con la cantidad de inasistencias.
    //Cuál empleado faltó menos días.
    class Empleado
    {
        private string[] nombre;
        private int[][] inasistencia;
        public void Carga()
        {
            string linea;
            int dias;
            nombre = new string[4];
            inasistencia = new int[4][];
            for (int f=0;f<nombre.Length;f++)
            {
                Console.Write("Ingrese el nombre del empleado: ");
                nombre[f] = Console.ReadLine();
                Console.Write("Ingrese la cantidad de dias de inasistencia: ");
                linea = Console.ReadLine();
                dias = int.Parse(linea);
                inasistencia[f] = new int[dias];
                for (int i = 0; i < inasistencia[f].Length;i++)
                {
                    Console.Write("Ingrese el nro de dia: ");
                    linea = Console.ReadLine();
                    inasistencia[f][i] = int.Parse(linea);
                }
            }
        }
        public void Imprimir() 
        {
            for(int f=0;f<nombre.Length;f++)
            {
                Console.WriteLine("Nombre del empleado: "+ nombre[f]);
                Console.Write("Dias de inasistencia: ");
                for (int i = 0; i < inasistencia[f].Length; i++)
                {
                    Console.Write(" {0} ", inasistencia[f][i]);
                }
                Console.WriteLine();
            }
        }
        public void MenorInasistencia() 
        {
            int help = inasistencia[0].Length;
            string help1="";
            for (int f=0;f<inasistencia.Length;f++)
            {

                    if (inasistencia[f].Length<help)
                    {
                        help = inasistencia[f].Length;
                        help1 = nombre[f];
                    }
            }
            Console.WriteLine("El empleado que tuvo menos inasistencia fue {0} con {1} inasitencia.", help1,help);
        }
        static void Main(string[] args)
        {
            Empleado e = new Empleado();
            Console.WriteLine("Carga de informacion de Inasistencia");
            e.Carga();
            Console.WriteLine();
            e.Imprimir();
            Console.WriteLine();
            e.MenorInasistencia();
            Console.ReadLine();
        }
    }
}
