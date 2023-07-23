using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pract59
{
    //Implementar la clase operaciones.Se deben cargar dos valores enteros en el constructor,
    //calcular su suma, resta, multiplicación y división, cada una en un método, imprimir dichos resultados.
    class Operaciones 
    {
        private int num1;
        private int num2;
        public Operaciones() 
        {
            string linea;
            Console.Write("Ingresar el primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingresar el segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
        }
        public int Suma() 
        {
            int suma= num1+num2;
            return suma;
        }
        public int Resta() 
        {
            int resta = num1 - num2;
            return resta;
        }
        public int Multiplica() 
        {
        int multiplica = num1 * num2;   
            return multiplica;
        }
        public float Divide() 
        {
            float divided = num1 / num2;  
            return divided;
        }
        static void Main(string[] args)
        {
            Operaciones o = new Operaciones();
            Console.WriteLine();
            Console.Write("La suma: {0}\nLa resta: {1}\nLa multiplicacion: {2}\nLa divicion: {3}", o.Suma(), o.Resta(), o.Multiplica(), o.Divide()) ;
            Console.ReadKey();
        }
    }
}
