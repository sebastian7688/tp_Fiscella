using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract39
{
    internal class Program
    {
        //En un banco se procesan datos de las cuentas corrientes de sus clientes.De cada cuenta 
        //corriente se conoce: número de cuenta y saldo actual.El ingreso de datos debe finalizar
        //al ingresar un valor negativo en el número de cuenta.
        //Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe:
        //a)De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
        //Estado de la cuenta	'Acreedor' si el saldo es >0.
			//'Deudor' si el saldo es<0.
			//'Nulo' si el saldo es = 0.
        //b) La suma total de los saldos acreedores.
        static void Main(string[] args)
        {
            int numeroCuenta;
            float saldo, suma=0;
            string linea;
            do
            {
                Console.Write("Ingresar el numero de cuenta: ");
                linea = Console.ReadLine();
                numeroCuenta = int.Parse(linea);
                if (numeroCuenta >= 0)
                {
                    Console.Write("Ingresar saldo actual: ");
                    linea = Console.ReadLine();
                    saldo = float.Parse(linea);
                    Console.WriteLine();
                    Console.WriteLine("Numero Cuenta: " + numeroCuenta);
                    if (saldo == 0)
                    {
                        Console.WriteLine("Estado de Cuenta: Nulo");
                    }
                    else if (saldo < 0)
                    {
                        Console.WriteLine("Estado de Cuenta: Deudor");
                    }
                    else
                    {
                        Console.WriteLine("Estado de Cuenta: Acreedor");
                        suma = suma + saldo;
                    }
                    Console.WriteLine();
                }
            }
            while (numeroCuenta>=0);
            Console.WriteLine();
            if (suma == 0) 
            {
                Console.Write("No hay acreedores o No ingreso un valor valido");
            }
            else
            {
                Console.WriteLine("La suma de los saldos acreedores es " + suma);
                
            }
            Console.ReadKey();
        }
    }
}
