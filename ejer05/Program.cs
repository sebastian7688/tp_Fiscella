using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ejer05
{
    //Crearemos una clase llamada Serie con las siguientes características:
    //Sus atributos son título, número de temporadas, entregado, genero y creador.
    //Por defecto, el número de temporadas es de 3 temporadas y entregado false. El resto de atributos serán valores por defecto según el tipo del atributo.
    //Los constructores que se implementarán serán:
    //Un constructor por defecto.
    //Un constructor con título y creador. El resto por defecto.
    //Un constructor con todos los atributos, excepto de entregado.
    //Los métodos que se implementara serán:
    //Métodos get de todos los atributos, excepto de entregado.
    //Métodos set de todos los atributos, excepto de entregado.
    //Crearemos una clase Videojuego con las siguientes características:
    //Sus atributos son titulo, horas estimadas, entregado, genero y compañia.
    //Por defecto, las horas estimadas serán de 10 horas y entregado false. El resto de atributos serán valores por defecto según el tipo del atributo.
    //Los constructores que se implementarán serán:
    //Un constructor por defecto.
    //Un constructor con el título y horas estimadas. El resto por defecto.
    //Un constructor con todos los atributos, excepto de entregado.
    //Los métodos que se implementara serán:
    //Métodos get de todos los atributos, excepto de entregado.
    //Métodos set de todos los atributos, excepto de entregado.
    //Como vemos, en principio, las clases anteriores no son padre-hija, pero si tienen en común, por eso vamos a hacer una interfaz llamada Entregable con los siguientes métodos:
    //entregar(): cambia el atributo prestado a true.
    //devolver(): cambia el atributo prestado a false.
    //isEntregado(): devuelve el estado del atributo prestado.
    //Método compareTo (Object a), compara las horas estimadas en los videojuegos y en las series el número de temporadas.Como parámetro que tenga un objeto, no es necesario que implementen la interfaz Comparable. Recuerda el uso de los casting de objetos.
    //Implementa los anteriores métodos en las clases Videojuego y Serie. Ahora crea una aplicación ejecutable y realiza lo siguiente:
    //Crea dos arrays, uno de Series y otro de Videojuegos, de 5 posiciones cada uno.
    //Crea un objeto en cada posición del array, con los valores que desees, puedes usar distintos constructores.
    //Entrega algunos Videojuegos y Series con el método entregar().
    //Cuenta cuantos Series y Videojuegos hay entregados.Al contarlos, devuelvelos.
    //Por último, indica que el Videojuego tiene más horas estimadas y la serie con mas temporadas. Muestran en pantalla con toda su información
    interface Entregable
    {
        void entregar();
        void devolver();
        bool isEntregado();
    }
    public class Series : Entregable
    {
        private string titulo;
        private int nro_temporadas;
        private bool entregado;
        private string creador;
        private string genero;
        public Series()
        {
            nro_temporadas = 3;
            entregado = false;
        }
        public Series(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
            entregado = false;
            nro_temporadas = 3;
        }
        public Series(int nro_temporadas, string creador, string genero, string titulo)
        {
            this.titulo = titulo;
            this.creador = creador;
            this.genero = genero;
            entregado = false;
            this.nro_temporadas = nro_temporadas;
        }
        public void SetNro_temporadas(int nro_temporadas)
        {

                this.nro_temporadas = nro_temporadas;

        }
        public int GetNro_temporadas()
        {

                return nro_temporadas;

        }
        public string GetCreador()
        {
            return creador;
        }
        public void SetCreador (string creador)
        {
        this.creador=creador;
        }
        public string GetTitulo()
        {
            return titulo;
        }
        public void SetTitulo(string tiutlo) 
        {
        this.titulo=tiutlo;
        }
        public string GetGenero()
        {
            return genero;
        }
        public void SetGenero(string genero)
        {
        this.genero=genero;
        }
        public void entregar() 
        {
            entregado=true;
        }
        public void devolver() 
        {
            entregado=false;
        }
        public bool isEntregado() 
        {
        return entregado;
        }

    }
    public class Videojuegos:Entregable
    {
        private string titulo;
        private int horas_estimadas=10;
        private bool entregado=false;
        private string genero;
        private string compañia;

        public Videojuegos(string titulo, int horas_estimadas, string genero, string compañia)
        {
            this.titulo = titulo;
            this.horas_estimadas = horas_estimadas;
            this.genero = genero;
            this.compañia = compañia;
            entregado = false;
        }
        public Videojuegos(string titulo,int horas_estimadas) 
        {
            this.titulo= titulo;
            this.horas_estimadas= horas_estimadas;
            entregado = false;
        }
        public string GetTitulo()
        {
             return titulo; 
        }
        public void SetTitulo(string titulo) 
        {
            this.titulo = titulo;
        }
        public string GetGenero() 
        {
             return genero; 
        }
        public void SetGenero(string genero)
        {
        this.genero= genero;
        }
        public string GetCompañia() 
        {
            return compañia; 
        }
        public void SetCompañia(string compañia) 
        {
            this.compañia = compañia;
        }
        public int GetHoras_Estimadas() 
        {
             return horas_estimadas;
        }
        public void SetHoras_Estimadas(int horas)
        {
        this.horas_estimadas = horas;   
        }

        public void entregar()
        {
            entregado = true;
        }
        public void devolver()
        {
            entregado = false;
        }
        public bool isEntregado()
        {
            return entregado;
        }
    }
    public class Aplicacion
    {
        static void Main(string[] args)
        {
            Series[] s = new Series[5];
            Videojuegos[] v = new Videojuegos[5];
            s[0] = new Series("Dragon ball", "Akiro Toritama");
            s[1] = new Series(11, "Robert Kirkman", "zombis", "The walking dead");
            s[2] = new Series(2, "Tomohito Oda", "romance", "Komi-san no puede comunicarse");
            s[3] = new Series(10, "Pendleton Ward", "aventura", "Hora de aventura");
            s[4] = new Series(5, "David Shore y Daniel Dae Kim", "Drama", "The good doctot");
            v[0] = new Videojuegos("Dark soul", 33);
            v[1] = new Videojuegos("the last of us", 18,"accion y aventura", "Naughty Dog");
            v[2] = new Videojuegos("Metal slug", 7, "accion", "SNK");
            v[3] = new Videojuegos("Pokemon Esmeralda", 30);
            v[4] = new Videojuegos("Minecraft", 5, "supervivencia y creatividad", "mojan");
            s[3].entregar();
            s[0].entregar();
            v[1].entregar();
            v[2].entregar();
            int series_entregadas = 0;
            int video_juegos_Entr = 0;
            Series serieMasTemporadas = s[0];
            Videojuegos juegosMasHoras = v[0];
            foreach (Series se in s)
            {
                if (se.isEntregado())
                {
                series_entregadas++;
                }
            }
            foreach (Videojuegos vi in v)
            {
                if (vi.isEntregado())
                {
                video_juegos_Entr++;
                }
            }
            v[1].GetHoras_Estimadas();
            foreach (Series ser in s)
            {
                if (ser.GetNro_temporadas()>serieMasTemporadas.GetNro_temporadas())
                {
                serieMasTemporadas= ser;
                }


            }
            foreach (Videojuegos vio in v)
            {
                if (vio.GetHoras_Estimadas() > juegosMasHoras.GetHoras_Estimadas())
                {
                    juegosMasHoras = vio;
                }

            }
            Console.WriteLine("Hay {0} juegos entregados",video_juegos_Entr);
            Console.WriteLine("Hay {0} series entregados", series_entregadas);
            Console.WriteLine("La serie con mas temporadas: ");
            Console.WriteLine("Titulo: "+ serieMasTemporadas.GetTitulo());
            Console.WriteLine("Temporadas: "+ serieMasTemporadas.GetNro_temporadas());
            Console.WriteLine("Genero: "+serieMasTemporadas.GetGenero());
            Console.WriteLine("Creador: "+serieMasTemporadas.GetCreador());
            Console.WriteLine();
            Console.WriteLine("El juego con mas horas estimadas");
            Console.WriteLine("Titulo: " + juegosMasHoras.GetTitulo());
            Console.WriteLine("Horas Estimadas: " + juegosMasHoras.GetHoras_Estimadas());
            Console.WriteLine("Genero: " + juegosMasHoras.GetGenero());
            Console.WriteLine("Compañia: " + juegosMasHoras.GetCompañia());
            Console.ReadKey();

        }
    }

}
