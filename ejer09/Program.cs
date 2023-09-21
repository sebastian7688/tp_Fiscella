using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer09
{
    //Nos piden hacer un programa orientado a objetos sobre un cine(solo de una sala)
    //tiene un conjunto de asientos(8 filas por 9 columnas, por ejemplo).
    //Del cine nos interesa conocer la película que se está reproduciendo y
    //el precio de la entrada en el cine.
    //De las películas nos interesa saber el título, duración, edad mínima y director.
    //Del espectador, nos interesa saber su nombre, edad y el dinero que tiene.
    //Los asientos son etiquetados por una letra (columna) y un número (fila),
    //la fila 1 empieza al final de la matriz como se muestra en la tabla.
    //También deberemos saber si está ocupado o no el asiento.
    //8 A 8 B 8 C 8 D 8 E 8 F 8 G 8 H 8 I
    //7 A 7 B 7 C 7 D 7 E 7 F 7 G 7 H 7 I
    //6 A 6 B 6 C 6 D 6 E 6 F 6 G 6 H 6 I
    //5 A 5 B 5 C 5 D 5 E 5 F 5 G 5 H 5 I
    //4 A 4 B 4 C 4 D 4 E 4 F 4 G 4 H 4 I
    //3 A 3 B 3 C 3 D 3 E 3 F 3 G 3 H 3 I
    //2 A 2 B 2 C 2 D 2 E 2 F 2 G 2 H 2 I
    //1 A 1 B 1 C 1 D 1 E 1 F 1 G 1 H 1 I
    //Realizaremos una pequeña simulación, en el que generamos muchos espectadores
    //y los sentamos aleatoriamente (no podemos donde ya esté ocupado).
    //En esta versión sentaremos a los espectadores de uno en uno.
    //Solo se podrá sentar si tienen el suficiente dinero, hay espacio libre y
    //tiene edad para ver la película, en caso de que el asiento esté ocupado
    //le buscamos uno libre.
    //Los datos del espectador y la película pueden ser totalmente aleatorios.
    class Espectador
    {
        public string Nombre { get; }
        public int Edad { get; }
        public double Dinero { get; }

        public Espectador(string nombre, int edad, double dinero)
        {
            Nombre = nombre;
            Edad = edad;
            Dinero = dinero;
        }
    }
    class Pelicula
    {
        public string Titulo { get; }
        public int Duracion { get; }
        public int EdadMinima { get; }
        public string Director { get; }

        public Pelicula(string titulo, int duracion, int edadMinima, string director)
        {
            Titulo = titulo;
            Duracion = duracion;
            EdadMinima = edadMinima;
            Director = director;
        }
    }

    class Asiento
    {
        public bool Ocupado { get; private set; }
        public Espectador Espectador { get; private set; }
        public Pelicula Pelicula { get; private set; }

        public void Ocupar(Espectador espectador, Pelicula pelicula)
        {
            Espectador = espectador;
            Pelicula = pelicula;
            Ocupado = true;
        }
    }
    class Cinema
    {
        private string nombre;
        private int filas;
        private int columnas;
        private double BoletoPrecio;
        private List<Pelicula> peliculas;
        private Asiento[,] asientos;

        public Cinema(string nombre, int filas, int columnas, double BoletoPrecio)
        {
            this.nombre = nombre;
            this.filas = filas;
            this.columnas = columnas;
            this.BoletoPrecio = BoletoPrecio;
            this.peliculas = new List<Pelicula>();
            this.asientos = new Asiento[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    asientos[i, j] = new Asiento();
                }
            }
        }

        public void SetPeliculas(List<Pelicula> peliculas)
        {
            this.peliculas = peliculas;
        }

        public bool AsientosDisponibles()
        {
            return asientos.Cast<Asiento>().Any(asiento => !asiento.Ocupado);
        }

        public bool AsignarAsiento(Espectador espectador, Pelicula pelicula)
        {
            for (int i = filas - 1; i >= 0; i--)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Asiento asiento = asientos[i, j];
                    if (!asiento.Ocupado)
                    {
                        asiento.Ocupar(espectador, pelicula);
                        Console.WriteLine($"{espectador.Nombre} se ha sentado en la fila {i + 1}, asiento {((char)('A' + j))} para ver '{pelicula.Titulo}'.");
                        return true;
                    }
                }
            }
            return false;
        }

        public void ImprimirEstadoCine()
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Asiento asiento = asientos[i, j];
                    Console.Write($"Fila {i + 1}, Asiento {((char)('A' + j))}: {(asiento.Ocupado ? "Ocupado" : "Libre")}\t");
                }
                Console.WriteLine();
            }
        }
    }

    


    class Help
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("Mi Cine", 8, 9, 7.0); 

            List<Pelicula> peliculas = new List<Pelicula>
        {
            new Pelicula("Pelicula 1", 120, 12, "Director 1"),
            new Pelicula("Pelicula 2", 90, 18, "Director 2"),
            new Pelicula("Pelicula 3", 150, 15, "Director 3"),
        };

            cinema.SetPeliculas(peliculas);

            Random random = new Random();

            for (int i = 1; i <= 10; i++)
            {
                string espectadorNombre = "Espectador " + i;
                int espectadorEdad = random.Next(5, 70); 
                double espectadorDinero = random.NextDouble() * 10; 

                Espectador espectador = new Espectador(espectadorNombre, espectadorEdad, espectadorDinero);

                bool sentado = false;

                foreach (Pelicula p in peliculas)
                {
                    if (espectador.Edad >= p.EdadMinima && cinema.AsientosDisponibles())
                    {
                        sentado = cinema.AsignarAsiento(espectador, p);
                        if (sentado)
                            break;
                    }
                }

                if (!sentado)
                {
                    Console.WriteLine($"{espectador.Nombre} no pudo encontrar un asiento adecuado.");
                }
            }

            Console.WriteLine("\nEstado final del cine:");
            cinema.ImprimirEstadoCine();
            Console.ReadKey();
        }
    }

    
}
