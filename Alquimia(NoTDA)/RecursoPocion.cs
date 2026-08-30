using System;

namespace AlquimiaProyecto
{
    public class RecursoPocion
    {
        public string NombrePocion { get; set; }
        private bool recursoAbierto;

        public RecursoPocion(string nombre)
        {
            NombrePocion = nombre;
            recursoAbierto = true;
            Console.WriteLine($"\n[Memoria Dinámica] Poción '{NombrePocion}'  Recursos  asignados.");
        }

        public void UsarPocion()
        {
            if (recursoAbierto)
            {
                Console.WriteLine($"[Efecto] ¡Has bebido la poción {NombrePocion}! Magia fluyendo en el sistema.");
            }
            else
            {
                Console.WriteLine($"[Error] La poción {NombrePocion} ya no tiene energía.");
            }
        }

       
        ~RecursoPocion()
        {
            if (recursoAbierto)
            {
                Console.WriteLine($"\n[DESTRUCTOR] El objeto '{NombrePocion}' ha muerto. Liberando Magia dinámica y cerrando flujos de lineas ley.");
            }
        }
    }
}