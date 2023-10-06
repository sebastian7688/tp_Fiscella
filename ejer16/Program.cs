using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer16
{

    class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica agenda = new AgendaTelefonica(); 

            int opcion;
            do
            {
                Console.WriteLine("\nMenú de Agenda Telefónica");
                Console.WriteLine("1. Añadir Contacto");
                Console.WriteLine("2. Comprobar si Existe Contacto");
                Console.WriteLine("3. Listar Contactos");
                Console.WriteLine("4. Buscar Contacto por Nombre");
                Console.WriteLine("5. Eliminar Contacto");
                Console.WriteLine("6. Agenda Llena");
                Console.WriteLine("7. Huecos Libres");
                Console.WriteLine("8. Salir");
                Console.Write("Elija una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.Clear();

                    switch (opcion)
                    {

                        case 1:

                            Console.Write("Ingrese el nombre del contacto: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Ingrese el teléfono del contacto: ");
                            string telefono = Console.ReadLine();
                            Contacto nuevoContacto = new Contacto(nombre, telefono);
                            if (agenda.AniadirContacto(nuevoContacto))
                            {
                                Console.WriteLine("Contacto añadido correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("No se pudo añadir el contacto. Agenda llena o nombre duplicado.");
                            }
                            Console.Clear();

                            break;

                        case 2:
                            Console.Write("Ingrese el nombre del contacto a comprobar: ");
                            string nombreComprobar = Console.ReadLine();
                            if (agenda.ExisteContacto(new Contacto(nombreComprobar, "")))
                            {
                                Console.WriteLine("El contacto existe en la agenda.");
                            }
                            else
                            {
                                Console.WriteLine("El contacto no existe en la agenda.");

                            }
                            

                            break;

                        case 3:
                            Console.WriteLine("Lista de Contactos:");
                            agenda.ListarContactos();

                            break;

                        case 4:
                            Console.Write("Ingrese el nombre del contacto a buscar: ");
                            string nombreBuscar = Console.ReadLine();
                            Contacto contactoEncontrado = agenda.BuscaContacto(nombreBuscar);
                            if (contactoEncontrado != null)
                            {
                                Console.WriteLine($"Nombre: {contactoEncontrado.Nombre}, Teléfono: {contactoEncontrado.Telefono}");
                            }
                            else
                            {
                                Console.WriteLine("El contacto no fue encontrado.");
                                

                            }

                            break;

                        case 5:
                            Console.Write("Ingrese el nombre del contacto a eliminar: ");
                            string nombreEliminar = Console.ReadLine();
                            Contacto contactoAEliminar = new Contacto(nombreEliminar, "");
                            if (agenda.EliminarContacto(contactoAEliminar))
                            {
                                Console.WriteLine("Contacto eliminado correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("El contacto no existe en la agenda.");
                            }

                            break;

                        case 6:
                            if (agenda.AgendaLlena())
                            {
                                Console.WriteLine("La agenda está llena.");
                            }
                            else
                            {
                                Console.WriteLine("La agenda no está llena.");
                            }

                            break;

                        case 7:
                            Console.WriteLine($"Huecos libres en la agenda: {agenda.HuecosLibres()}");
                            break;

                        case 8:
                            Console.WriteLine("Saliendo del programa.");
                            Console.Clear();

                            break;

                        default:
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            Console.Clear();

                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Intente nuevamente.");
                }
                
            }
            
            while (opcion != 8);
            Console.ReadKey();  
        }
    }
}
