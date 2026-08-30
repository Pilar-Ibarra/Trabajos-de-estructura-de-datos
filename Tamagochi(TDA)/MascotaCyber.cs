using System;

namespace TamagotchiTDA
{
    public class MascotaCyber
    {
        public string Nombre { get; set; }
        public int Hambre { get; set; } = 50;
        public int Energia { get; set; } = 50;

        public MascotaCyber(string nombre)
        {
            Nombre = nombre;
            Console.WriteLine($"[Sistema] Mascota {Nombre} inicializada en la red.");
        }

        // El destructor requerido para la tarea
        ~MascotaCyber()
        {
            Console.WriteLine($"[ALERTA] El núcleo de {Nombre} ha sido destruido. Memoria liberada.");
        }
    }
}