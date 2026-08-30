using System;
using System.Collections.Generic;

namespace DronesProyecto
{
    public class MenuConsola
    {
        private List<Drone> flota = new List<Drone>();

        public void Iniciar()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE MONITOREO DE DRONES (ESTÁTICO) ===");
                CentralMonitoreo.MostrarEstadoRed(); 
                Console.WriteLine("================================================");
                Console.WriteLine("1. Registrar nuevo dron");
                Console.WriteLine("2. Consultar lista de drones en vuelo");
                Console.WriteLine("3. Destruir / Dar de baja un dron (Probar Destructor)");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        RegistrarDrone();
                        break;
                    case "2":
                        ListarDrones();
                        break;
                    case "3":
                        EliminarDrone();
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

            Console.WriteLine("\nSaliendo del sistema de drones. ¡Hasta luego!");
        }

        private void RegistrarDrone()
        {
            Console.Write("Ingresa el ID numérico del dron: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Console.Write("Ingresa la zona de patrullaje: ");
                string zona = Console.ReadLine() ?? "Zona Desconocida";

                Drone nuevoDrone = new Drone(id, zona);
                flota.Add(nuevoDrone);
            }
            else
            {
                Console.WriteLine("[Error] ID inválido.");
            }
            Pausar();
        }

        private void ListarDrones()
        {
            Console.WriteLine("\n--- DRONES EN LA RED ---");
            if (flota.Count == 0)
            {
                Console.WriteLine("No hay drones registrados.");
            }
            else
            {
                foreach (var d in flota)
                {
                    Console.WriteLine($"- Dron ID: {d.Id} | Ubicación: {d.Ubicacion}");
                }
            }
            Pausar();
        }

        private void EliminarDrone()
        {
            Console.WriteLine("\n--- DAR DE BAJA DRON ---");
            Console.Write("Ingresa el ID del dron a eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int idBaja))
            {
                Drone dronEncontrado = flota.Find(d => d.Id == idBaja);
                if (dronEncontrado != null)
                {
                    flota.Remove(dronEncontrado);
                    dronEncontrado = null; // Rompemos referencia para activar destructor
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Console.WriteLine("[Acción] Dron removido de la flota y memoria liberada.");
                }
                else
                {
                    Console.WriteLine("[Aviso] No se encontró un dron con ese ID.");
                }
            }
            Pausar();
        }

        private void Pausar()
        {
            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
