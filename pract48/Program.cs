using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract48
{
    //Desarrollar un programa que permita ingresar un vector de n elementos,
    //ingresar n por teclado.Luego imprimir la suma de todos sus elementos
    class XD 
    {
    private int[] numero;
        public void Carga()
        {
            int n,x=1;
            string linea;
            Console.Write("Ingresar la cantidad del vector: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            numero = new int[n];
            for (int f=0;f<numero.Length;f++) 
            {
                Console.Write("Ingresar el {0}° Valor: ",x);
                linea = Console.ReadLine();
                numero[f] = int.Parse(linea);
                x++;
            }
        }
        public int SumaVector() 
        {
            int suma = 0;
            for (int f =0;f<numero.Length;f++)
            {
                suma = suma + numero[f];
            }
            return suma;
        }
        static void Main(string[] args)
        {
            XD xd = new XD();
            xd.Carga();
            Console.WriteLine();
            Console.WriteLine("La suma total del vector es :"+xd.SumaVector());
            Console.ReadKey();
        }
    }
}
