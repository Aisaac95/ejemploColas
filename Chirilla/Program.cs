using Chirilla;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChirillaVillarroel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lista miLista = new lista();
            int opcion = 0;

            do
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Mostrar");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Mostrar Valor medio");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("INGRESE LA CANTIDAD DE NUMEROS: ");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.Write($"INGRESE EL VALOR  {i + 1}: ");
                            int valorInsertar = Convert.ToInt32(Console.ReadLine());
                            miLista.insertarF(valorInsertar);
                        }
                        break;

                    case 2:
                        miLista.mostrar();
                        break;

                    case 3:
                        Console.Write("Ingrese el valor a eliminar: ");
                        int valorEliminar = Convert.ToInt32(Console.ReadLine());
                        miLista.EliminarNodo(valorEliminar);
                        break;

                    case 4:
                        int? valorMedio = miLista.ObtenerValorMedio();
                        if (valorMedio.HasValue)
                        {
                            Console.WriteLine($"El valor en la posición media es: {valorMedio.Value}");
                        }
                        else
                        {
                            Console.WriteLine("No hay valores en la lista.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();

            } while (opcion != 5);
        }
    }
}
