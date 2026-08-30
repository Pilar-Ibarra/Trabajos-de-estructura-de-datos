using System;

namespace EstructuraProyecto
{
    public class MiPilaPersonalizada
    {
        private string[] elementos;
        private int tope; 

        public MiPilaPersonalizada(int capacidadInicial)
        {
            elementos = new string[capacidadInicial]; 
            tope = 0;
            Console.WriteLine($"[Estructura] Pila creada con capacidad estática inicial de {capacidadInicial}.");
        }

        
        public void Push(string dato)
        {
            
            if (tope >= elementos.Length)
            {
                Console.WriteLine("\n[ Alerta] La estructura se llenó. Redimensionando array tradicional con n + 1 / duplicando...");
                string[] nuevoArray = new string[elementos.Length * 2];

                for (int i = 0; i < elementos.Length; i++)
                {
                    nuevoArray[i] = elementos[i];
                }

                elementos = nuevoArray;
            }

            elementos[tope] = dato;
            tope++;
            Console.WriteLine($"[Push] '{dato}' agregado a la estructura en la posición {tope - 1}.");
        }

                public string Pop()
        {
            if (EstaVacia())
            {
                Console.WriteLine("[Error] La estructura está vacía (Underflow).");
                return null;
            }

            tope--;
            string elementoSacado = elementos[tope];
            elementos[tope] = null; // Limpiamos la referencia
            Console.WriteLine($"[Pop] '{elementoSacado}' retirado de la cima de la estructura.");
            return elementoSacado;
        }

        
        public int ObtenerTamaño()
        {
            return tope;
        }

        public bool EstaVacia()
        {
            return tope == 0;
        }

        
        public void MostrarEstructura()
        {
            Console.WriteLine("\n--- ESTADO DE LA PILA PERSONALIZADA ---");
            if (EstaVacia())
            {
                Console.WriteLine("La estructura está vacía.");
            }
            else
            {
                for (int i = tope - 1; i >= 0; i--)
                {
                    Console.WriteLine($"[{i}] -> {elementos[i]} {(i == tope - 1 ? "(Cima)" : "")}");
                }
            }
            Console.WriteLine("----------------------------------------");
        }
    }
}