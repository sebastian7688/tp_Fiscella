using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pract47
{
    //Cargar un vector de 10 elementos y verificar posteriormente si el mismo está ordenado de menor a mayor.
    class Elemento 
    {
        private int[] num;
        public void Carga() 
        {
            string linea;
            num = new int[10];
            int x = 1;
            for (int f=0;f<10;f++) 
            {
                Console.Write("Ingresar el {0}° Valor: ",x);
                linea = Console.ReadLine();
                num[f] = int.Parse(linea);
                x++;
            }
        }
        public void Verificar() 
        {
            int y = 1;
            for (int f =0;f<9;f++)
            {
                if (num[f+1] < num[f]) 
                {
                    y = 0;
                }
            }
            if (y == 1)
            {
                Console.WriteLine("El array esta ordenado de menor a mayor");
            }
            else if (y==0)
            {
                Console.WriteLine("El array no esta ordenado");
            }
        }
        static void Main(string[] args)
        {
            Elemento e = new Elemento();
            e.Carga();
            Console.WriteLine();
            e.Verificar();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
