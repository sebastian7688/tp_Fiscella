using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ejer06
{
    //Crear una clase Libro que contenga los siguientes atributos:
    //– ISBN
    //– Título
    //– Autor
    //– Número de páginas
    //Crear sus respectivos métodos get y set correspondientes para cada atributo.
    //Crear el método que muestre la información relativa al libro con el siguiente formato:
    //«El libro con ISBN creado por el autor tiene páginas»
    //En el fichero main, crear 2 objetos Libro (los valores que se quieran) y mostrarlos por pantalla.
    //Por último, indicar cuál de los 2 tiene más páginas.
    public class Libro 
    {
        private string isbn;
        private string titulo;
        private string autor;
        private int nro_paginas;

        public string GetTitulo() 
        {
            return titulo;
        }
        public void SetTitulo(string titulo)
        {
        this.titulo= titulo;
        }
        public string GetAutor() 
        {
        return autor;
        }
        public void SetAutor(string autor) 
        {
        this.autor= autor;
        }
        public int GetNro_paginas() 
        {
        return nro_paginas;
        }
        public void SetNro_paginas(int nro_paginas)
        {
        this.nro_paginas= nro_paginas;  
        }
        public string GetIsbn() 
        {
        return isbn;
        }
        public void SetIsbn(string isbn) 
        {
        this.isbn= isbn;
        }
        public void MostrarInfo() 
        {
            Console.WriteLine($"El libro '{titulo}' con ISBN {isbn} creado por {autor} tiene {nro_paginas} páginas.");
        }
    }
    public class Help 
    {
        static void Main(string[] args) 
        {
            Libro l1 = new Libro();
            l1.SetTitulo("El juramento de los Centenera");
            l1.SetAutor("Lydia Carreras de Sosa");
            l1.SetNro_paginas(192);
            l1.SetIsbn("978-987-642-020-4");
            Libro l2 = new Libro();
            l2.SetTitulo("El Fuego Secreto");
            l2.SetAutor("C.J. Daugherty");
            l2.SetNro_paginas(384);
            l2.SetIsbn("978-987-747-142-7");
            l1.MostrarInfo();
            l2.MostrarInfo();
            if (l1.GetNro_paginas() > l2.GetNro_paginas())
            {
                Console.WriteLine("El primer libro tiene mas paginas");
            }
            else 
            {
                if (l1.GetNro_paginas() < l2.GetNro_paginas())
                {
                    Console.WriteLine("El segundo libro tiene mas paginas");
                }
                else 
                {
                Console.WriteLine("Ambos libros tiene la misma cantidad de paginas");
                }
            }
            Console.ReadKey();
        }
    }
}
