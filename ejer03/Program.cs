using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejer03
{
//    Haz una clase llamada Password que siga las siguientes condiciones:
//Que tenga los atributos longitud y contraseña.Por defecto, la longitud sera de 8.
//Los constructores serán los siguiente:
//Un constructor por defecto.
//Un constructor con la longitud que nosotros le pasemos. Generará una contraseña aleatoria con esa longitud.
//Los métodos que implementa serán:
//esFuerte(): devuelve un booleano si es fuerte o no, para que sea fuerte debe tener mas de 2 mayúsculas, mas de 1 minúscula y mas de 5 números.
//generarPassword():  genera la contraseña del objeto con la longitud que tenga.
//Método get para contraseña y longitud.
//Método set para longitud.
//Ahora, crea una clase clase ejecutable:
//Crea un array de Passwords con el tamaño que tu le indiques por teclado.
//Crea un bucle que cree un objeto para cada posición del array.
//Indica también por teclado la longitud de los Passwords (antes de bucle).
//Crea otro array de booleanos donde se almacene si el password del array de Password es o no fuerte(usa el bucle anterior).
//Al final, muestra la contraseña y si es o no fuerte(usa el bucle anterior). Usa este simple formato:
//contraseña1 valor_booleano1
//contraseña2 valor_bololeano2
    public class Password
    {
        private int longitud;
        private string contraseña;

        public Password()
        {
            longitud = 8;
            generarPassword();
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            generarPassword();
        }

        public void generarPassword()
        {
            Random rnd = new Random();
            const string mayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numeros = "0123456789";

            string caracteres = mayusculas + mayusculas.ToLower() + numeros;

            char[] contraseñaArr = new char[longitud];
            for (int f = 0; f < longitud; f++)
            {
                contraseñaArr[f] = caracteres[rnd.Next(caracteres.Length)];
            }

            contraseña = new string(contraseñaArr);
        }

        public bool esFuerte()
        {
            int mayusculasCount = 0;
            int minusculasCount = 0;
            int numerosCount = 0;

            foreach (char c in contraseña)
            {
                if (char.IsUpper(c))
                    mayusculasCount++;
                else if (char.IsLower(c))
                    minusculasCount++;
                else if (char.IsDigit(c))
                    numerosCount++;
            }
            if (mayusculasCount > 2 && minusculasCount > 1 && numerosCount > 5)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public int Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
        }
    }

    public class Help
    {
        public static void Main(string[] args)
        {
            Console.Write("Ingrese la longitud para los Passwords: ");
            int longitud = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de Passwords que desea crear: ");
            int cantidadPasswords = int.Parse(Console.ReadLine());

            Password[] passwords = new Password[cantidadPasswords];
            bool[] esFuerteArray = new bool[cantidadPasswords];

            for (int f = 0; f < cantidadPasswords; f++)
            {
                passwords[f] = new Password(longitud);
                esFuerteArray[f] = passwords[f].esFuerte();
            }

            Console.WriteLine("\nContraseñas generadas y si son fuertes o no:");

            for (int i = 0; i < cantidadPasswords; i++)
            {
                Console.WriteLine(passwords[i].Contraseña + " " + esFuerteArray[i]);
            }
            Console.ReadKey();
        }
    }
}
