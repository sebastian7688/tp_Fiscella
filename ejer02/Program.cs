using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ejer02
{
    //Haz una clase llamada Persona que siga las siguientes condiciones:
    //Sus atributos son: nombre, edad, DNI, sexo(H hombre, M mujer), peso y altura.No queremos
    //que se accedan directamente a ellos.Piensa que modificador de acceso es el más adecuado,
    //también su tipo.Si quieres añadir algún atributo puedes hacerlo.
    //Por defecto, todos los atributos menos el DNI serán valores por defecto según su tipo
    //(0 números, cadena vacía para String, etc.). Sexo sera hombre por defecto, usa una constante para ello.
    //Se implantaran varios constructores:
    //Un constructor por defecto.
    //Un constructor con el nombre, edad y sexo, el resto por defecto.
    //Un constructor con todos los atributos como parámetro.
    //Los métodos que se implementarán son:
    //calcularIMC(): calculará si la persona está en su peso ideal (peso en kg/(altura^2  en m)),
    //si esta fórmula devuelve un valor menor que 20, la función devuelve un -1,
    //si devuelve un número entre 20 y 25 (incluidos), significa que está por debajo de su peso
    //ideal la función devuelve un 0  y si devuelve un valor mayor que 25 significa que tiene sobrepeso,
    //la función devuelve un 1. Te recomiendo que uses constantes para devolver estos valores.
    //esMayorDeEdad(): indica si es mayor de edad, devuelve un booleano.
    //comprobarSexo(char sexo): comprueba que el sexo introducido es correcto.Si no es correcto,
    //será H.No será visible al exterior.
    //generaDNI(): genera un número aleatorio de 8 cifras, genera a partir de este su número su
    //letra correspondiente.Este método será invocado cuando se construya el objeto.
    //Puedes dividir el método para que te sea más fácil. No será visible al exterior.
    //Métodos set de cada parámetro, excepto de DNI.
    class Persona
    {
        private string nombre;
        private int edad;
        private char sexo;
        private double peso;
        private double altura;
        private readonly string DNI;
        private const char Hombre = 'H';
        public Persona()
        {
            this.nombre= string.Empty;
            this.edad= 0;
            this.altura= 0.0;
            this.peso= 0.0;
            this.sexo = Hombre;
            this.DNI = GenerarDNI();
        }
        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = comprobarSexo(sexo);
            this.peso = 0.0;
            this.altura = 0.0;
            this.DNI = GenerarDNI();
        }
        public Persona(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = comprobarSexo(sexo);
            this.peso = peso;
            this.altura = altura;
            this.DNI = GenerarDNI();
        }
        public int CalcularIMC() 
        {
            double imc = peso / (altura*altura);
            if (imc < 20)
            {
                return -1;
            }
            else 
            {
                if (imc >= 20 && imc <= 25)
                {
                    return 0;
                }
                else 
                {
                    return 1;
                }
            }
        }
        public bool esMayorDeEdad() 
        {
            if (edad >= 18)
            {
                return true;
            }
            else 
            {
            return false;
            }
        }
        private char comprobarSexo(char sexo)
        {
            //return (sexo == 'H' || sexo == 'M') ? sexo : Hombre;
            if (sexo == 'H' || sexo == 'M')
            {
                return sexo;
            }
            else 
            {
                return Hombre;
            }
        }
        public string GenerarDNI() 
        {
            Random random = new Random();
            string dni = random.Next(10000000, 99999999).ToString();
            return dni+ CalcularLetraDNI(dni);
        }
        private char CalcularLetraDNI(string dni)
        {
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            int indice = int.Parse(dni) % 23;
            return letras[indice];
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public void SetSexo(char sexo)
        {
            this.sexo = comprobarSexo(sexo);
        }

        public void SetPeso(double peso)
        {
            this.peso = peso;
        }

        public void SetAltura(double altura)
        {
            this.altura = altura;
        }

        public string GetDNI()
        {
            return DNI;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public int GetEdad()
        {
            return edad;
        }
        public char GetSexo()
        {
            return sexo;

        }
        public double GetPeso()
        {
            return peso;
        }
        public double GetAltura()
        {
            return altura;
        }
    }

    public class Help
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Datos para la persona 1:");
            Console.Write("Nombre: ");
            string nombre1 = Console.ReadLine();

            Console.Write("Edad: ");
            int edad1 = int.Parse(Console.ReadLine());

            Console.Write("Sexo (H/M): ");
            char sexo1 = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Peso (kg): ");
            double peso1 = double.Parse(Console.ReadLine());

            Console.Write("Altura (m): ");
            double altura1 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Datos para la persona 2 (sin peso y altura):");
            Console.Write("Nombre: ");
            string nombre2 = Console.ReadLine();

            Console.Write("Edad: ");
            int edad2 = int.Parse(Console.ReadLine());

            Console.Write("Sexo (H/M): ");
            char sexo2 = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.WriteLine();

            Persona persona1 = new Persona(nombre1, edad1, sexo1, peso1, altura1);
            Persona persona2 = new Persona(nombre2, edad2, sexo2);

            Persona persona3 = new Persona();
            persona3.SetNombre("Persona 3");
            persona3.SetEdad(30);
            persona3.SetSexo('H');
            persona3.SetPeso(80.5);
            persona3.SetAltura(1.85);

            Console.WriteLine("\nInformación de la persona 1:");
            MostrarInformacion(persona1);

            Console.WriteLine("\nInformación de la persona 2:");
            MostrarInformacion(persona2);

            Console.WriteLine("\nInformación de la persona 3:");

            MostrarInformacion(persona3);
            Console.ReadKey();
        }

        private static void MostrarInformacion(Persona persona)
        {
            Console.WriteLine("Nombre: " + persona.GetNombre());
            Console.WriteLine("Edad: " + persona.GetEdad());
            Console.WriteLine("Sexo: " + persona.GetSexo());
            Console.WriteLine("DNI: " + persona.GetDNI());
            Console.WriteLine("Peso: " + persona.GetPeso() + " kg");
            Console.WriteLine("Altura: " + persona.GetAltura() + " m");

            int imc = persona.CalcularIMC();
            string estadoIMC = "";
            if (imc == -1)
                estadoIMC = "por debajo de su peso ideal";
            else if (imc == 0)
                estadoIMC = "en su peso ideal";
            else if (imc == 1)
                estadoIMC = "con sobrepeso";

            Console.WriteLine("Estado IMC: " + estadoIMC);
            Console.WriteLine("Es mayor de edad: " + (persona.esMayorDeEdad() ? "Sí" : "No"));
           
        }

    }
}
