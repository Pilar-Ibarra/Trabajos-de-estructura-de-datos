using System;

namespace DronesProyecto
{
    public class Drone
    {
        // Memoria estática compartida por toda la red
        public static int TotalDronesActivos = 0;

        public int Id { get; set; }
        public string Ubicacion { get; set; }

        public Drone(int id, string ubicacion)
        {
            Id = id;
            Ubicacion = ubicacion;
            TotalDronesActivos++;
            Console.WriteLine($"\n[Éxito] Dron #{Id} desplegado en {Ubicacion}.");
        }

        // El destructor requerido para limpiar memoria
        ~Drone()
        {
            TotalDronesActivos--;
            Console.WriteLine($"\n[⚠️ DESTRUCTOR] Dron #{Id} destruido de la memoria.");
        }
    }
}