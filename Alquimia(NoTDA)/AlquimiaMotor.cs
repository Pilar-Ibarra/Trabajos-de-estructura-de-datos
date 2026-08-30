using System;

namespace AlquimiaProyecto
{
    public class AlquimiaMotor
    {
        public void Mezclar(RecursoPocion p1, RecursoPocion p2)
        {
            Console.WriteLine($"\n[Fusión] Mezclando los componentes de {p1.NombrePocion} y {p2.NombrePocion}...");
            Console.WriteLine("[Resultado] ¡Se ha creado una súper poción inestable en magia");
        }
    }
}