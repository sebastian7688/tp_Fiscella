using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pract62
{
    //Plantear una clase Club y otra clase Socio.
    //La clase Socio debe tener los siguientes atributos privados:
    //nombre y la antigüedad en el club (en años)
    //Definir dos propiedades para poder acceder al nombre y la antigüedad del socio
    //(no permitir cargar un valor negativo en la antigüedad).
    //La clase Club debe tener como atributos 3 objetos de la clase Socio.
    //Definir una responsabilidad para imprimir el nombre del socio con mayor antigüedad en el club.
    class Socio
    {
        private string nombre;
        private int antiguedad;
        public string Nombre 
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int Antiguedad 
        {
            set 
            {
                if (value > 0)
                {
                    antiguedad = value;
                }
                else 
                {
                    Console.WriteLine("No se puede un valor negativo en la antiguedad.");
                }
            }
            get 
            {
            return antiguedad;
            }
        }
    }
    class Club
    {
        private Socio socio1, socio2, socio3;
        public Club () 
        {
            socio1=new Socio ();
            socio1.Nombre = "Juan";
            socio1.Antiguedad = 2;
            socio2=new Socio ();
            socio2.Nombre = "vale";
            socio2.Antiguedad= 3;
            socio3=new Socio ();
            socio3.Nombre = "Seba";
            socio3.Antiguedad= 1;
        }
        public void ImprimirMayor()
        {
            if (socio1.Antiguedad > socio2.Antiguedad && socio1.Antiguedad > socio3.Antiguedad)
            {
                Console.WriteLine("Socio con mayor antiguedad: " + socio1.Nombre);
            }
            else 
            {
                if (socio2.Antiguedad > socio1.Antiguedad && socio2.Antiguedad > socio3.Antiguedad)
                {
                    Console.WriteLine("Socio con mayor antiguedad: " + socio2.Nombre);
                }
                else 
                {
                    Console.WriteLine("Socio con mayor antiguedad: "+ socio3.Nombre);
                }
            }
        }
        static void Main(string[]args)
        {
            Club c = new Club();
            c.ImprimirMayor();
            Console.ReadLine();
        }
        
    }
}
