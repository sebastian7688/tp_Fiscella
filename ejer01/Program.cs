using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer01
{
    //Crea una clase llamada Cuenta que tendrá los siguientes atributos: titular y cantidad(puede tener decimales).
    //El titular será obligatorio y la cantidad es opcional.Crea dos constructores que cumplan lo anterior.
    //Tendrá dos métodos especiales:
    //ingresar(double cantidad) : se ingresa una cantidad a la cuenta,
    //si la cantidad introducida es negativa, no se hará nada.
    //retirar(double cantidad): se retira una cantidad a la cuenta,
    //si restando la cantidad actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.
    class Cuenta 
    {
        private string titular;
        private double cantidad;
        public Cuenta(string titular) 
        {        
            this.titular = titular;
            this.cantidad = 0.0;
        
        }
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            if (cantidad >= 0)
            {
                this.cantidad = cantidad;
            }
            else 
            {
                this.cantidad = 0.0;
            }
        }

        public void Ingresar(double cantidad) 
        {
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }
        public void Retirar(double cantidad) 
        {
            if (cantidad>0)
            {
                this.cantidad-=cantidad;
                if (this.cantidad<0)
                {
                    this.cantidad = 0.0;
                }
            }
        }
        public string Titular
        {
            set
            {
                titular = value;
            }
            get
            {
                return titular;
            }
        }
        public double Cantidad
        {
            set
            {
                cantidad = value;
            }
            get
            {
                return cantidad;
            }
        }
        static void Main(string[] args)
        {
            Cuenta c1 = new Cuenta("Valentino", 600.50);
            Cuenta c2 = new Cuenta("Juan");
            Cuenta c3 = new Cuenta("Leandro", 99.99);
            c1.Retirar(700);
            c2.Ingresar(1000);
            c3.Ingresar(99.99);
            Console.WriteLine("Titular de la cuenta: {0}\nSaldo: {1}.",c1.Titular,c1.Cantidad);
            Console.WriteLine("Titular de la cuenta: {0}\nSaldo: {1}.", c2.Titular, c2.Cantidad);
            Console.WriteLine("Titular de la cuenta: {0}\nSaldo: {1}.", c3.Titular, c3.Cantidad);
            Console.ReadKey();

        }
    }
}
