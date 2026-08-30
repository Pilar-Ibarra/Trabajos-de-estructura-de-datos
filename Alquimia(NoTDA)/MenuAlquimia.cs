using System;

namespace AlquimiaProyecto
{
    public class MenuAlquimia
    {
        // Usamos un arreglo tradicional en lugar de List<T>
        private RecursoPocion[] laboratorio = new RecursoPocion[2]; // Empezamos chiquito para probar el redimensionamiento
        private int contadorPociones = 0;

        public void Iniciar()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== LABORATORIO DE POCIONES===");
                Console.WriteLine($"Pociones activas: {contadorPociones} / Capacidad : {laboratorio.Length}");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Fabricar nueva poción ");
                Console.WriteLine("2. Listar pociones en inventario");
                Console.WriteLine("3. Desechar poción ");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        FabricarPocion();
                        break;
                    case "2":
                        ListarPociones();
                        break;
                    case "3":
                        DestruirPocion();
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

            Console.WriteLine("\nSaliendo del laboratorio...");
        }

        private void FabricarPocion()
        {
            Console.Write("Ingresa el nombre de la poción: ");
            string nombre = Console.ReadLine() ?? "Poción genérica";

            
            if (contadorPociones >= laboratorio.Length)
            {
                Console.WriteLine("\n[ALERTA DE MEMORIA] El almacen está lleno. Redimensionando y copiando a uno nuevo...");
                
                int nuevaCapacidad = laboratorio.Length * 2; 
                RecursoPocion[] nuevoArreglo = new RecursoPocion[nuevaCapacidad];

            
                for (int i = 0; i < laboratorio.Length; i++)
                {
                    nuevoArreglo[i] = laboratorio[i];
                }

                laboratorio = nuevoArreglo; 
            }

            
            RecursoPocion nuevaPocion = new RecursoPocion(nombre);
            laboratorio[contadorPociones] = nuevaPocion;
            contadorPociones++;

            Pausar();
        }

        private void ListarPociones()
        {
            Console.WriteLine("\n--- INVENTARIO CON ARRAY TRADICIONAL ---");
            if (contadorPociones == 0)
            {
                Console.WriteLine("No hay pociones fabricadas.");
            }
            else
            {
                for (int i = 0; i < contadorPociones; i++)
                {
                    if (laboratorio[i] != null)
                    {
                        Console.WriteLine($"{i}. Poción: {laboratorio[i].NombrePocion}");
                    }
                }
            }
            Pausar();
        }

        private void DestruirPocion()
        {
            ListarPociones();
            if (contadorPociones > 0)
            {
                Console.Write("Ingresa el índice de la poción a destruir: ");
                if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < contadorPociones)
                {
                    
                    laboratorio[index] = null; 

                   
                    for (int i = index; i < contadorPociones - 1; i++)
                    {
                        laboratorio[i] = laboratorio[i + 1];
                    }
                    laboratorio[contadorPociones - 1] = null;
                    contadorPociones--;

                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    Console.WriteLine("[Acción] Poción eliminada y memoria compactada.");
                }
                else
                {
                    Console.WriteLine("[Error] Índice inválido.");
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