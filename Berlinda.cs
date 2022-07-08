public class Berlina : Vehiculo
{
    public Berlina()
    {
        descripcion = "Berlina";
    }
 
    public override int VelocidadMaxima()
    {
        return 180;
    }
 
    public override double Consumo()
    {
        return 6.2;
    }
}