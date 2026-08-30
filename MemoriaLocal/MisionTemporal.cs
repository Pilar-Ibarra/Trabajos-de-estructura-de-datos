using System;

namespace MemoriaLocalProyecto
{
    public class MisionTemporal
    {
        public void EjecutarMision(string nombreMision)
        {
            
            int energiaInicial = 100;
            string estado = "Activa";
            DateTime horaInicio = DateTime.Now;

            Console.WriteLine($"\n[ STACK] Entrando a la misión: '{nombreMision}'");
            Console.WriteLine($"- Variable local 'energiaInicial': {energiaInicial}");
            Console.WriteLine($"- Variable local 'estado': {estado}");
            Console.WriteLine($"- Variable local 'horaInicio': {horaInicio:HH:mm:ss}");

            
            for (int i = 1; i <= 3; i++)
            {
                
                int energiaConsumida = i * 15;
                int energiaRestante = energiaInicial - energiaConsumida;
                Console.WriteLine($"  -> Iteración {i}: Energía consumida = {energiaConsumida}, Restante = {energiaRestante}");
            }

            Console.WriteLine($"[STACK] Saliendo de la misión '{nombreMision}'. Las variables locales acaban de morir.");
        }
    }
}