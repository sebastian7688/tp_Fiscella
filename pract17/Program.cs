using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract17
{
    internal class Program
    {
        //Se ingresan tres valores por teclado, si todos son iguales se imprime
        //la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.
        static void Main(string[] args)
        {
            int num1, num2, num3,suma, multiplica;
            string linea;
            Console.Write("Ingrese el primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingrese el tercer valor: ");
            linea= Console.ReadLine();
            num3 = int.Parse(linea);
            suma = num1 + num2;
            multiplica = suma * num3;
            if (num1==num2 && num2==num3)
            {
                Console.WriteLine("Resultado: "+ multiplica);
            }
            Console.ReadKey();

        }
    }
}
