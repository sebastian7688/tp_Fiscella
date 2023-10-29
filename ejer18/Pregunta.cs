using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ejer18
{
    class Pregunta
    {
        public string Enunciado { get; set; }
        public List<Opcion> Opciones { get; set; }
        public int OpcionCorrecta { get; set; }
        public int Puntos { get; set; }

        public Pregunta()
        {
            Opciones = new List<Opcion>();
        }

        public void MostrarPregunta()
        {
            Console.WriteLine(Enunciado);
            for (int i = 0; i < Opciones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Opciones[i].Texto}");
            }
        }

        public bool ComprobarRespuesta(int respuestaUsuario)
        {
            if (respuestaUsuario >= 1 && respuestaUsuario <= Opciones.Count)
            {
                //return Opciones[respuestaUsuario - 1].EsCorrecta;
                //return true;
                if (respuestaUsuario == OpcionCorrecta + 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
