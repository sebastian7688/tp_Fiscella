using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer04
{
    //    Crearemos una superclase llamada Electrodoméstico con las siguientes características:
    //Sus atributos son precio base, color, consumo energético(letras entre A y F) y peso.Indica que se podrán
    //heredar.AS
    //Por defecto, el color será blanco, el consumo energético será F, el precioBase es de 100 € y
    //el peso de 5 kg.Usa constantes para ello.
    //Los colores disponibles son blanco, negro, rojo, azul y gris.No importa si el nombre está
    //en mayúsculas o en minúsculas.
    //Los constructores que se implementarán serán
    //Un constructor por defecto.
    //Un constructor con el precio y peso.El resto por defecto.
    //Un constructor con todos los atributos.
    //Los métodos que implementara serán:
    //Métodos get de todos los atributos.
    //comprobarConsumoEnergetico(char letra): comprueba que la letra es correcta, sino es correcta usará
    //la letra por defecto. Se invocará al crear el objeto y no será visible.
    //comprobarColor(String color): comprueba que el color es correcto, sino lo es usa el color por defecto.
    //Se invocará al crear el objeto y no será visible.
    //precioFinal(): según el consumo energético, aumentará su precio, y según su tamaño, también.
    //Esta es la lista de precios:
    //Letra
    //Precio
    //A
    //100 €
    //B
    //80 €
    //C
    //60 €
    //D
    //50 €
    //E
    //30 €
    //F
    //10 €


    //Tamaño
    //Precio
    //Entre 0 y 19 kg
    //10 €
    //Entre 20 y 49 kg
    //50 €
    //Entre 50 y 79 kg
    //80 €
    //Mayor que 80 kg
    //100 €
    //Crearemos una subclase llamada Lavadora con las siguientes características:
    //Su atributo es carga, además de los atributos heredados.
    //Por defecto, la carga es de 5 kg.Usa una constante para ello.
    //Los constructores que se implementarán serán:
    //Un constructor por defecto.
    //Un constructor con el precio y peso.El resto por defecto.
    //Un constructor con la carga y el resto de atributos heredados.Recuerda que debes llamar al constructor de la clase padre.
    //Los métodos que se implementara serán:
    //Método get de carga.
    //precioFinal():, si tiene una carga mayor de 30 kg, aumentará el precio 50 €, sino es así no se incrementará el precio. Llama al método padre y añade el código necesario.Recuerda que las condiciones que hemos visto en la clase Electrodoméstico también deben afectar al precio.
    //Crearemos una subclase llamada Televisión con las siguientes características:
    //Sus atributos son resolución (en pulgadas) y sintonizador TDT (booleano), además de los atributos heredados.
    //Por defecto, la resolución será de 20 pulgadas y el sintonizador será false.
    //Los constructores que se implementarán serán:
    //Un constructor por defecto.
    //Un constructor con el precio y peso.El resto por defecto.
    //Un constructor con la resolución, sintonizador TDT y el resto de atributos heredados. Recuerda que debes llamar al constructor de la clase padre.
    //Los métodos que se implementara serán:
    //Método get de resolución y sintonizador TDT.
    //precioFinal(): si tiene una resolución mayor de 40 pulgadas, se incrementará el precio un 30% y si tiene un sintonizador TDT incorporado, aumentará 50 €. Recuerda que las condiciones que hemos visto en la clase Electrodoméstico también deben afectar al precio.
    //Ahora crea una clase ejecutable que realice lo siguiente:
    //Crea un array de electrodomésticos de 10 posiciones.
    //Asigna a cada posición un objeto de las clases anteriores con los valores que desees.
    //Ahora, recorre este array y ejecuta el método precioFinal().
    //Deberás mostrar el precio de cada clase, es decir, el precio de todas las televisiones por un lado, el de las lavadoras por otro y la suma de los electrodomésticos (puedes crear objetos Electrodomésticos, pero recuerda que Televisión y Lavadora también son electrodomésticos). Recuerda el uso operador instanceof.
    //Por ejemplo, si tenemos un electrodoméstico con un precio final de 300, una lavadora de 200 y una televisión de 500, el resultado final será de 1000 (300+200+500) para electrodomésticos, 200 para lavadora y 500 para televisión.
    public class Electrodomestico
    {
        private double precio;
        private string color;
        private char consumo_energetico;
        private double peso;
        protected const double Precio_Base = 100;
        protected const string Color_Base = "color";
        protected const char Consumo_Energetico_Base = 'F';
        protected const double Peso_Base = 5;
        public Electrodomestico()
        {
            this.precio = Peso_Base;
            this.consumo_energetico = Consumo_Energetico_Base;
            this.color = Color_Base;
            this.peso = Peso_Base;
        }
        public Electrodomestico(double precio, double peso)
        {
            this.precio = precio;
            this.peso = peso;
            this.color = Color_Base;
            this.consumo_energetico = Consumo_Energetico_Base;
        }
        public Electrodomestico(double precio, double peso, string color, char consumo_energetico)
        {
            this.precio = precio;
            this.peso = peso;
            this.color = comprobarColor(color);
            this.consumo_energetico = comprobarConsumoEnergetico(consumo_energetico);
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        public double Peso
        {
            get
            {
                return peso;
            }
            set
            {
                this.peso = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                this.color = value;
            }
        }
        public char Consumo_Electronico
        {
            get
            {
                return consumo_energetico;
            }
            set
            {
                this.consumo_energetico = value;
            }
        }
        public char comprobarConsumoEnergetico(char letra)
        {
            if (letra >= 'A' && letra <= 'F')
            {
                return letra;
            }
            else
            {
                return Consumo_Energetico_Base;
            }
            //return (letra >= 'A' && letra <= 'F') ? letra : Consumo_Energetico_Base;
        }
        public string comprobarColor(string color)
        {
            string[] colores = { "blanco", "rojo", "negro", "azul", "gris" };
            string help = color.ToLower();
            foreach (string c in colores)
            {
                if (help == c)
                {
                    return c;
                }
            }
            return Color_Base;
        }
        public virtual double Precio_Final()
        {
            double precioConsumo = 0;
            switch (precioConsumo)
            {
                case 'A':
                    precioConsumo += 100;
                    break;
                case 'B':
                    precioConsumo += 80;
                    break;
                case 'C':
                    precioConsumo += 60;
                    break;
                case 'D':
                    precioConsumo += 50;
                    break;
                case 'E':
                    precioConsumo += 30;
                    break;
                case 'F':
                    precioConsumo += 10;
                    break;
            }
            double presioPeso = 0;
            if (peso > 0 && peso <= 19)
            {
                presioPeso += 10;
            }
            else if (peso >= 20 && peso <= 49)
            {
                presioPeso += 50;
            }
            else if (peso >= 50 && peso <= 79)
            {
                presioPeso += 80;
            }
            else if (peso >= 80)
            {
                presioPeso += 100;
            }
            return presioPeso + precioConsumo + precio;

        }
    }
    public class Lavadora : Electrodomestico
    {
        private double carga;
        protected double Carga_Base = 5;
        public Lavadora() : base()
        {
            this.carga = Carga_Base;
        }
        public Lavadora(double peso, double precio) : base(peso, precio)
        {
            this.carga = Carga_Base;
        }
        public Lavadora(double carga, double peso, double precio, char consumo_energetico, string color) :
        base(peso, precio, color, consumo_energetico)
        {
            this.carga = carga;
        }
        public double Carga
        {
            get
            {
                return carga;
            }
            set
            {
                this.carga = value;
            }
        }
        public override double Precio_Final()
        {
            double preciolavadora = base.Precio_Final();
            if (carga > 30)
            {
                preciolavadora += 50;
            }
            return preciolavadora;
        }
    }
    public class Television : Electrodomestico
    {
        private double resolucion;
        private bool sincronizador_TDT;
        protected double Resolucion_Base = 20;
        protected bool Sincronizador_TDT_Base = false;
        public Television() : base()
        {
            this.resolucion = Resolucion_Base;
            this.sincronizador_TDT = Sincronizador_TDT_Base;
        }
        public Television(double peso, double precio) : base(peso, precio)
        {
            this.resolucion = Resolucion_Base;
            this.sincronizador_TDT = Sincronizador_TDT_Base;
        }
        public Television(double resolucion, bool sincronizador_DTD, double peso, double precio, char consumo_energetico, string color) : base(peso, precio, color, consumo_energetico)
        {
            this.resolucion = resolucion;
            this.sincronizador_TDT = sincronizador_DTD;
        }
        public double Resolucion
        {
            get
            {
                return resolucion;
            }
        }
        public bool Sincronizador_TDT
        {
            get
            {
                return sincronizador_TDT;
            }
        }
        public override double Precio_Final()
        {
            double precioTelevision = base.Precio_Final();
            if (resolucion > 40)
            {
                precioTelevision += precioTelevision * 30 / 100;
            }
            if (sincronizador_TDT == true)
            {
                precioTelevision += 50;
            }
            return precioTelevision;
        }
    }
    public class Help
    {
        static void Main(string[] args)
        {
            Electrodomestico[] e = new Electrodomestico[10];
            e[0] = new Lavadora(300, 500);
            e[1] = new Lavadora(8, 300, 500, 'A', "rojo");
            e[2] = new Lavadora(3, 150, 200, 'D', "gris");
            e[3] = new Lavadora(500, 1500);
            e[4] = new Lavadora(12, 500, 1800, 'A', "negro");
            e[5] = new Television(500, 1000);
            e[6] = new Television(50, true, 30, 2000, 'A', "negro");
            e[7] = new Television(20, false, 50, 800, 'F', "blanca");
            e[8] = new Television(50, 800);
            e[9] = new Television(100, true, 25, 3000, 'A', "negro");
            double precioTotalElectrodomesticos = 0;
            double precioTotalLavadoras = 0;
            double precioTotalTelevisores = 0;
            foreach (Electrodomestico electrodomestico in e)
            {
                double precioFinal = electrodomestico.Precio_Final();
                precioTotalElectrodomesticos += precioFinal;

                if (electrodomestico is Lavadora)
                {
                    precioTotalLavadoras += precioFinal;
                }
                else if (electrodomestico is Television)
                {
                    precioTotalTelevisores += precioFinal;
                }
            }

            Console.WriteLine("Precio total electrodomésticos: " + precioTotalElectrodomesticos);
            Console.WriteLine("Precio total lavadoras: " + precioTotalLavadoras);
            Console.WriteLine("Precio total televisores: " + precioTotalTelevisores);
            Console.ReadKey();
        }
    }
}


