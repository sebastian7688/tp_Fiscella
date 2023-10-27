using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer18
{
    class Test
    {
        private List<Pregunta> preguntas;
        private int preguntaActual;
        private int puntosAcumulados;

        public Test()
        {
            preguntas = new List<Pregunta>();
            preguntaActual = 0;
            puntosAcumulados = 0;
        }

        public void CargarPreguntas(string fichero)
        {
            string[] lineas = File.ReadAllLines(fichero);
            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i].StartsWith(";P;"))
                {
                    Pregunta pregunta = new Pregunta
                    {
                        Texto = lineas[i].Substring(3),
                        Opciones = new List<Opcion>(),
                        OpcionCorrecta = int.Parse(lineas[i + 5].Substring(3)),
                        Puntos = int.Parse(lineas[i + 6].Substring(3))
                    };

                    for (int j = 1; j <= 4; j++)
                    {
                        pregunta.Opciones.Add(new Opcion
                        {
                            Texto = lineas[i + j],
                            EsCorrecta = j == pregunta.OpcionCorrecta
                        });
                    }

                    preguntas.Add(pregunta);
                    i += 6;
                }
            }
        }

        public Pregunta SiguientePregunta()
        {
            if (preguntaActual < preguntas.Count)
            {
                return preguntas[preguntaActual++];
            }
            return null;
        }

        public void ReiniciarTest()
        {
            preguntaActual = 0;
            puntosAcumulados = 0;
        }

        public void RealizarTest()
        {
            Pregunta pregunta;
            while ((pregunta = SiguientePregunta()) != null)
            {
                pregunta.MostrarPregunta();
                Console.Write("Introduce tu respuesta: ");
                int respuestaUsuario = int.Parse(Console.ReadLine());

                if (pregunta.ComprobarRespuesta(respuestaUsuario))
                {
                    Console.WriteLine("Respuesta correcta. ¡Has ganado " + pregunta.Puntos + " puntos!");
                    puntosAcumulados += pregunta.Puntos;
                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta. La respuesta correcta era la opción " + pregunta.OpcionCorrecta);
                }
            }

            Console.WriteLine("Test completado. Puntos totales: " + puntosAcumulados);
        }
    }
}
