using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract28
{
    internal class Program
    {
        //Realizar un programa que permita cargar dos listas de 15 valores cada una.
        //Informar con un mensaje cual de las dos listas tiene un valor acumulado mayor
        //(mensajes "Lista 1 mayor", "Lista 2 mayor", "Listas iguales")
        //Tener en cuenta que puede haber dos o más estructuras repetitivas en un algoritmo.
        static void Main(string[] args)
        {
            int lista1, lista2, x = 0, y = 0,z=3, sumaList1 = 0, sumaList2 = 0;
            string linea;
            while (x < z)
            {
                x++;
                Console.Write("Ingrese el {0}° Valor de la lista 1: ", x);
                linea = Console.ReadLine();
                lista1 = int.Parse(linea);
                sumaList1 = sumaList1 + lista1;
                
            }
            Console.WriteLine();
            while (y < z)
            {
                y++;
                Console.Write("Ingrese el {0}° Valor de la lista 2: ", y);
                linea = Console.ReadLine();
                lista2 = int.Parse(linea);
                sumaList2 = sumaList2 + lista2;
            }
            if (sumaList1 == sumaList2)
            {
                Console.WriteLine("Lista 1: {0} \nLista 2: {1}", sumaList1, sumaList2);
                Console.WriteLine("Listas Iguales");
            }
            else if (sumaList1 > sumaList2)
            {
                Console.WriteLine("Lista 1: {0} \nLista 2: {1}", sumaList1, sumaList2);
                Console.WriteLine("Lista 1 mayor");
            }
            else 
            {
                Console.WriteLine("Lista 1: {0} \nLista 2: {1}", sumaList1, sumaList2);
                Console.WriteLine("Lista 2 mayor");
            }
            Console.ReadKey();
        }
    }
}
