using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pract61
{
    //Plantear una clase Club y otra clase Socio.
    //La clase Socio debe tener los siguientes atributos privados:
    //nombre y la antigüedad en el club (en años).
    //En el constructor pedir la carga del nombre y su antigüedad.
    //La clase Club debe tener como atributos 3 objetos de la clase Socio.
    //Definir una responsabilidad para imprimir el nombre del socio con mayor antigüedad en el club.
    class Socio 
    {
        private string nombre;
        private int antiguedad;
        public Socio() 
        {
            string linea;
            Console.Write("Ingrese el nombre del socio: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese la antiguedad del socio (en años): ");
            linea = Console.ReadLine();
            antiguedad = int.Parse(linea);
        }
        public void Imprimir() 
        {
            Console.WriteLine(nombre+" tiene una antiguedad de "+antiguedad);
        }
        public int RetornaAntiguedad() 
        {
            return antiguedad;
        }

    }
    class Club 
    {
        private Socio socio1, socio2, socio3;
        public Club() 
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }
        public void MayorAntiguedad() 
        {
            Console.Write("El socio con mayor antiguedad: ");
            if (socio1.RetornaAntiguedad() > socio2.RetornaAntiguedad() && socio1.RetornaAntiguedad() > socio3.RetornaAntiguedad())
            {
                socio1.Imprimir();
            }
            else 
            {
                if (socio2.RetornaAntiguedad() > socio1.RetornaAntiguedad() && socio2.RetornaAntiguedad() > socio3.RetornaAntiguedad())
                {
                    socio2.Imprimir();
                }
                else 
                {
                    socio3.Imprimir();
                }
            }
        }
        static void Main(string[] args)
        {
            Club c = new Club();
            c.MayorAntiguedad();
            Console.ReadKey();
        }
    }
}
