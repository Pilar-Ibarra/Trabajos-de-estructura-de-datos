using System;

namespace MemoriaLocalProyecto
{
    public class MenuLocal
    {
        private MisionTemporal gestorMisiones = new MisionTemporal();

        public void Iniciar()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== DEMOSTRACIÓN DE MEMORIA LOCAL (STACK) ===");
                Console.WriteLine("1. Ejecutar misión");
                Console.WriteLine("2. Salir");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingresa el nombre de la misión temporal: ");
                        string nombre = Console.ReadLine() ?? "Misión sin nombre";
                        
                       
                        gestorMisiones.EjecutarMision(nombre);
                        Pausar();
                        break;
                    case "2":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("\n[Error] Opción no válida.");
                        Pausar();
                        break;
                }
            }

            Console.WriteLine("\nSaliendo del programa de memoria local...");
        }

        private void Pausar()
        {
            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ReadKey();
        }
    }
}