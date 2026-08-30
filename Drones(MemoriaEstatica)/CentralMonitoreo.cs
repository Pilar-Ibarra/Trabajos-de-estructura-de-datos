using System;

namespace DronesProyecto
{
    public static class CentralMonitoreo
    {
        // Método estático para consultar el estado global de la memoria estática
        public static void MostrarEstadoRed()
        {
            Console.WriteLine($"\n[📡 CENTRAL] Drones activos en la red estática: {Drone.TotalDronesActivos}");
        }
    }
}