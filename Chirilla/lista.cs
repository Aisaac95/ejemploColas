using ChirillaVilllarroel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirilla
{
    internal class lista
    {
        public nodo inicio;
        public lista()
        {
            inicio = null;
        }
        
        public void insertarF(int item)
        {
            nodo auxiliar = new nodo(); // creamos nodo temporal 
            auxiliar.dato = item; // almacenamos el valor 
            auxiliar.siguiente = null; // apunta al siguiente null
            if (inicio == null) // verificar si la lista está vacía
            {
                inicio = auxiliar;
            }
            else
            {
                nodo puntero; // para recoger el dato
                puntero = inicio;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente; // se despliega la lista
                }
                puntero.siguiente = auxiliar;
            }
        }
        public void mostrar()
        {

            if (inicio == null) // verificar si la lista esta vacia
            {
                Console.WriteLine("la lista es vacia no hay nada");
            }
            else
            {
                nodo puntero; // para recoge el dato
                puntero = inicio;
                Console.Write(puntero.dato +"\n");
                
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;// se desplega la lista
                    Console.WriteLine("\n" + puntero.dato);

                }
                Console.WriteLine();
            }
        }

        public void EliminarNodo(int item)
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía. No se puede eliminar el nodo.");
                return;
            }

            if (inicio.dato == item)
            {
                inicio = inicio.siguiente;
                return;
            }

            nodo puntero = inicio;
            while (puntero.siguiente != null && puntero.siguiente.dato != item)
            {
                puntero = puntero.siguiente;
            }

            if (puntero.siguiente == null)
            {
                Console.WriteLine("Nodo no encontrado.");
            }
            else
            {
                puntero.siguiente = puntero.siguiente.siguiente;
            }
        }

        public int? ObtenerValorMedio()
        {
            List<int> valores = new List<int>(); // Lista para almacenar los valores
            nodo actual = inicio; // Suponiendo que 'cabeza' es el primer nodo de la lista

            // Recorre la lista y agrega los valores a la lista
            while (actual != null)
            {
                valores.Add(actual.dato); // Agrega el valor a la lista
                actual = actual.siguiente; // Mueve al siguiente nodo
            }

            // Verifica si hay valores
            if (valores.Count > 0)
            {
                // Encuentra el índice del valor medio
                int medioIndex = valores.Count / 2;

                // Retorna el valor en la posición media
                return valores[medioIndex]; // Esto funciona tanto para listas de longitud impar como par
            }
            else
            {
                // Si no hay valores, retorna null
                return null;
            }
        }
        //metodod para insertar en una posicion del nodo 
        public void insertarPosicion(int item, int pos)
        {

        }
    }
}
