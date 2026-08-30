using System;

namespace TamagotchiTDA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombra a tu Tamagotchi: ");
            
            string nombre = Console.ReadLine() ?? "CyberBot";

            MascotaCyber miMascota = new MascotaCyber(nombre);
            MotorJuego juego = new MotorJuego();
            InterfazConsola ui = new InterfazConsola();

            bool vivo = true;
            while (vivo)
            {
                ui.MostrarEstado(miMascota);
                string opcion = Console.ReadLine() ?? "";

                if (opcion == "1")
                {
                    juego.Alimentar(miMascota);
                }
                else if (opcion == "2")
                {
                    juego.Dormir(miMascota);
                }
                else if (opcion == "3")
                {
                    vivo = false;
                }
            }

            // Limpiamos la referencia para disparar el destructor
            miMascota = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("\nPrograma finalizado. Presiona una tecla para salir.");
            Console.ReadKey();
        }
    }
}