namespace TamagotchiTDA
{
    public class MotorJuego
    {
        public void Alimentar(MascotaCyber mascota)
        {
            mascota.Hambre -= 15;
            if (mascota.Hambre < 0) mascota.Hambre = 0;
        }

        public void Dormir(MascotaCyber mascota)
        {
            mascota.Energia += 20;
            if (mascota.Energia > 100) mascota.Energia = 100;
        }
    }
}