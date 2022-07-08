public class Turbo : Decorator
{
    private Vehiculo vehiculo;
 
    public Turbo(Vehiculo vehiculo)
    {
        this.vehiculo = vehiculo;
    }
 
    public override string Descripcion()
    {
        return vehiculo.Descripcion() + " Turbo";
    }
 
    public override int VelocidadMaxima()
    {
        return vehiculo.VelocidadMaxima() + 30;
    }
 
    public override double Consumo()
    {
        return vehiculo.Consumo() + 0.4;
    }
}