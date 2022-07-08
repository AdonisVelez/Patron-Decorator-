public class Inyeccion : Decorator
{
    private Vehiculo vehiculo;
 
    public Inyeccion(Vehiculo vehiculo)
    {
        this.vehiculo = vehiculo;
    }
 
    public override string Descripcion()
    {
        return vehiculo.Descripcion() + " Inyección";
    }
 
    public override int VelocidadMaxima()
    {
        return vehiculo.VelocidadMaxima();
    }
 
    public override double Consumo()
    {
        return vehiculo.Consumo() - 1.2;
    }
}