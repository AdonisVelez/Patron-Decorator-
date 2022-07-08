using System;
namespace ExposicionCodigo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo monovolumen = new Monovolumen();
            monovolumen = new Gasolina(monovolumen);
            MostrarCaracteristicas(monovolumen);

            Vehiculo berlina = new Berlina();
            berlina = new Diesel(berlina);
            MostrarCaracteristicas(berlina);
            
            berlina = new Turbo(berlina);
            MostrarCaracteristicas(berlina);
            
            berlina = new Inyeccion(berlina);
            MostrarCaracteristicas(berlina);
            
            berlina = new CommonRail(berlina);
            MostrarCaracteristicas(berlina);

        }

        private static void MostrarCaracteristicas(Vehiculo v)
        {
            Console.WriteLine(string.Format("{0}\n\t- Velocidad punta de {1} km/h \n\tConsumo medio de {2} l/100km\n",
            v.Descripcion(),
            v.VelocidadMaxima(),
            v.Consumo()));
        }
    }
}