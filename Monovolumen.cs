public class Monovolumen : Vehiculo
{
    public Monovolumen()
    {
        descripcion = "Monovolumen";
    }
 
    // Funcionalidad básica
    public override int VelocidadMaxima()
    {
        return 160;
    }
 
    // Funcionalidad básica
    public override double Consumo()
    {
        return 7.5;
    }
}