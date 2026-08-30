using System;

namespace MemoriaLocalProyecto
{
    public class MisionTemporal
    {
        public void EjecutarMision(string nombreMision)
        {
            
            int energiaLocal = 100;
            int intentosRestantes = 3;
            bool misionEnCurso = true;

            Console.WriteLine($"\n[ STACK] Iniciando misión local: '{nombreMision}'");
            Console.WriteLine("Variables locales creadas en memoria local. ¡Comienza el desafío interactivo!\n");


            while (misionEnCurso && intentosRestantes > 0 && energiaLocal > 0)
            {
                Console.WriteLine($"--- ESTADO DE LA MISIÓN ---");
                Console.WriteLine($"Energía local actual: {energiaLocal}");
                Console.WriteLine($"Intentos locales restantes: {intentosRestantes}");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1. Hackear sistema (-20 energía)");
                Console.WriteLine("2. Forzar acceso directo (-50 energía y -1 intento)");
                Console.WriteLine("3. Abortar misión y salir");
                Console.Write("Elige una acción interactiva: ");

                string opcion = Console.ReadLine() ?? "";

                if (opcion == "1")
                {
                    energiaLocal -= 20;
                    Console.WriteLine("\n[Éxito] ¡Sistema hackeado con éxito!");
                    misionEnCurso = false; 
                }
                else if (opcion == "2")
                {
                    energiaLocal -= 50;
                    intentosRestantes--;
                    Console.WriteLine("\n[Aviso] Acceso forzado a la fuerza bruta.");
                    
                    if (energiaLocal <= 0 || intentosRestantes <= 0)
                    {
                        Console.WriteLine("[Derrota] Te has quedado sin recursos locales.");
                        misionEnCurso = false;
                    }
                }
                else if (opcion == "3")
                {
                    Console.WriteLine("\n[Abortado] Has decidido escapar.");
                    misionEnCurso = false;
                }
                else
                {
                    Console.WriteLine("\n[Error] Opción no válida, intenta de nuevo.");
                }

                if (misionEnCurso)
                {
                    Console.WriteLine("\nPresiona una tecla para continuar la misión...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Console.WriteLine($"\n[ STACK] Saliendo del método de la misión '{nombreMision}'.");
            Console.WriteLine("¡PUM! Las variables locales ('energiaLocal', 'intentosRestantes', 'misionEnCurso') acaban de desaparecer de la memoria RAM.");
        }
    }
}