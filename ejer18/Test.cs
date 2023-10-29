using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ejer18
{
    class Test
    {
        private List<Pregunta> preguntas;
        private int preguntaActual;

        public void CargarPreguntas(string fichero)
        {
            preguntas = new List<Pregunta>();
            string[] lineas = File.ReadAllLines(fichero);
            int i = 0;

            while (i < lineas.Length)
            {
                if (lineas[i].StartsWith(";P;"))
                {
                    Pregunta pregunta = new Pregunta();
                    pregunta.Enunciado = lineas[i].Substring(3);
                    pregunta.Opciones = new List<Opcion>();

                    i++;

                    while (!lineas[i].StartsWith(";R;") && !lineas[i].StartsWith(";P;") && i < lineas.Length)
                    {
                        if (!string.IsNullOrWhiteSpace(lineas[i]))
                        {
                            Opcion opcion = new Opcion();
                            opcion.Texto = lineas[i];
                            opcion.EsCorrecta = false;
                            pregunta.Opciones.Add(opcion);
                        }
                        i++;
                    }

                    if (lineas[i].StartsWith(";R;"))
                    {
                        pregunta.OpcionCorrecta = int.Parse(lineas[i].Substring(3)) - 1;
                        i++;
                    }
                    else
                    {
                        throw new Exception("Formato de archivo de preguntas incorrecto (falta especificar opción correcta).");
                    }

                    if (i < lineas.Length && !lineas[i].StartsWith(";P;"))
                    {
                        pregunta.Puntos = int.Parse(lineas[i]);
                    }
                    else
                    {
                        throw new Exception("Formato de archivo de preguntas incorrecto (falta especificar puntos).");
                    }

                    preguntas.Add(pregunta);
                }
                else
                {
                    i++;
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
        }

        public void RealizarTest()
        {
            ReiniciarTest();
            Pregunta pregunta;
            int puntosAcumulados = 0;

            while ((pregunta = SiguientePregunta()) != null)
            {
                pregunta.MostrarPregunta();
                Console.Write("Ingrese su respuesta: ");
                int respuestaUsuario;
                while (!int.TryParse(Console.ReadLine(), out respuestaUsuario) || respuestaUsuario < 1 || respuestaUsuario > pregunta.Opciones.Count)
                {
                    Console.WriteLine("Por favor, ingrese una opción válida.");
                }

                if (pregunta.ComprobarRespuesta(respuestaUsuario))
                {
                    Console.WriteLine("¡Respuesta correcta!");
                    puntosAcumulados += pregunta.Puntos;
                }
                else
                {
                    Console.WriteLine($"Respuesta incorrecta. La respuesta correcta era la opción {pregunta.OpcionCorrecta + 1}");
                }

                Console.WriteLine($"Opción correcta: {pregunta.OpcionCorrecta + 1}");
                Console.WriteLine($"Respuesta del usuario: {respuestaUsuario}");
                Console.WriteLine($"¿Es correcta? {pregunta.ComprobarRespuesta(respuestaUsuario)}");

                Console.WriteLine($"Puntos acumulados: {puntosAcumulados}\n");
            }
        }
    }
}
