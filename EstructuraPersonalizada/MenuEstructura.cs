using System;

namespace EstructuraProyecto
{
    public class MenuEstructura
    {
        private MiPilaPersonalizada pila = new MiPilaPersonalizada(2);

        public void Iniciar()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== ESTRUCTURA DE DATOS PROPIA (PILAS / STACK) ===");
                pila.MostrarEstructura();
                Console.WriteLine("1. Push (Insertar elemento)");
                Console.WriteLine("2. Pop (Extraer elemento)");
                Console.WriteLine("3. Ver tamaño actual");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingresa el valor a guardar: ");
                        string valor = Console.ReadLine() ?? "Sin valor";
                        pila.Push(valor);
                        Pausar();
                        break;
                    case "2":
                        pila.Pop();
                        Pausar();
                        break;
                    case "3":
                        Console.WriteLine($"\n[Info] Elementos totales: {pila.ObtenerTamaño()}");
                        Pausar();
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("\n[Error] Opción no válida.");
                        Pausar();
                        break;
                }
            }

            Console.WriteLine("\nSaliendo del programa...");
        }

        private void Pausar()
        {
            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ReadKey();
        }
    }
}