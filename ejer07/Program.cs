using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ejer07
{
    //Vamos a realizar una clase llamada Raíces, donde representaremos
    //los valores de una ecuación de 2º grado.
    //Tendremos los 3 coeficientes como atributos, llamémosles a, b y c.
    //Hay que insertar estos 3 valores para construir el objeto.
    //Las operaciones que se podrán hacer son las siguientes:
    //obtenerRaices(): imprime las 2 posibles soluciones
    //obtenerRaiz(): imprime una única raíz, que será cuando solo tenga
    //una solución posible.
    //getDiscriminante(): devuelve el valor del discriminante (double),
    //el discriminante tiene la siguiente fórmula, (b^2)-4* a* c
    //tieneRaices() : devuelve un booleano indicando si tiene dos soluciones,
    //para que esto ocurra, el discriminante debe ser mayor o igual que 0.
    //tieneRaiz() : devuelve un booleano indicando si tiene una única solución,
    //para que esto ocurra, el discriminante debe ser igual que 0.
    //calcular() : mostrará por consola las posibles soluciones que tiene
    //nuestra ecuación, en caso de no existir solución, mostrarlo también.
    //Fórmula ecuación 2º grado: (-b±√((b^2)-(4* a* c)))/(2* a)
    //Solo varía el signo delante de -b
    public class Raices 
    {
        private double a;
        private double b; 
        private double c;
        public Raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double getDiscriminante()
        {
            double discriminante = (b*b)-(4*a*c);
            return discriminante;
        }
        public void obtenerRaices()
        {
            double discriminante = getDiscriminante();

            if (tieneRaices())
            {
                double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                Console.WriteLine($"Raíz 1: {raiz1}");
                Console.WriteLine($"Raíz 2: {raiz2}");
            }
            else if (tieneRaiz())
            {
                double raizUnica = -b / (2 * a);
                Console.WriteLine($"Raíz única: {raizUnica}");
            }
            else
            {
                Console.WriteLine("No tiene soluciones reales.");
            }
        }
        public bool tieneRaices()
        {
            double discriminante = getDiscriminante();
            return discriminante >= 0;
        }

        public bool tieneRaiz()
        {
            double discriminante = getDiscriminante();
            return discriminante == 0;
        }
        public void Calcular() 
        {
            Console.WriteLine("Calculo de segundo grado: ");
            Console.WriteLine($"{a}x^2+{b}x+{c}");
            obtenerRaices();
        }
    }
    public class Help 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los coeficientes a, b y c de la ecuación de segundo grado:");

            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Raices ecuacion = new Raices(a, b, c);
            ecuacion.Calcular();
            Console.ReadKey();
        }
    }
}
