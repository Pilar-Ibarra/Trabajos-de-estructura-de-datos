using System;

namespace TamagotchiTDA
{
    public class InterfazConsola
    {
        public void MostrarEstado(MascotaCyber mascota)
        {
            Console.Clear();
            Console.WriteLine("=== TAMAGOTCHI CYBERPUNK ===");
            Console.WriteLine($"Nombre: {mascota.Nombre}");
            Console.WriteLine($"[Hambre]: {mascota.Hambre}");
            Console.WriteLine($"[Energía]: {mascota.Energia}");
            Console.WriteLine("============================");
            Console.WriteLine("1. Dar de comer");
            Console.WriteLine("2. Recargar energía (Dormir)");
            Console.WriteLine("3. Desconectar (Salir y destruir objeto)");
            Console.Write("Elige una opción: ");
        }
    }
}