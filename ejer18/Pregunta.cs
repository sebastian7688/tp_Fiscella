using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer18
{
    class Pregunta
    {
        public string Texto { get; set; }
        public List<Opcion> Opciones { get; set; }
        public int OpcionCorrecta { get; set; }
        public int Puntos { get; set; }

        public void MostrarPregunta()
        {
            Console.WriteLine(Texto);
            for (int i = 0; i < Opciones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Opciones[i].Texto}");
            }
        }

        public bool ComprobarRespuesta(int respuestaUsuario)
        {
            return Opciones[respuestaUsuario - 1].EsCorrecta;
        }
    }
}
