using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pract42
{
    //Implementar la clase operaciones.Se deben cargar dos valores enteros,
    //calcular su suma, resta, multiplicación y división, cada una en un método,
    //imprimir dichos resultados.
    class Operaciones
    {
        private int num1, num2;
        public void Carga()
        {
            string linea;
            Console.Write("Ingresar el numero 1: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingresar el numero 2: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
        }
        public void Suma()
        {
            int suma;
            suma = num1 + num2;
            Console.WriteLine("La suma es: "+suma);
        }
        public void Resta()
        {
            int resta;
            resta = num1 - num2;
            Console.WriteLine("La resta es: "+resta);
        }
        public void Multiplicar() 
        {
            int multiplicar;
            multiplicar = num1 * num2;
            Console.WriteLine("La multiplicacion es: "+multiplicar);
        }
        public void Dividir()
        {
            
            int dividir;
            dividir = num1 / num2;
            Console.WriteLine("la divicion es: "+ dividir);
        }
        static void Main(string[] args) 
        {
            Operaciones ope = new Operaciones();
            ope.Carga();
            ope.Suma();
            ope.Resta();
            ope.Multiplicar();
            ope.Dividir();
            Console.ReadKey();
            
        }
    }
}
