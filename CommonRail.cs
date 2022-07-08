public class CommonRail : Decorator
{
    private Vehiculo vehiculo;
 
    public CommonRail(Vehiculo vehiculo)
    {
        this.vehiculo = vehiculo;
    }
 
    public override string Descripcion()
    {
        return vehiculo.Descripcion() + " Common Rail";
    }
 
    public override int VelocidadMaxima()
    {
        return vehiculo.VelocidadMaxima() - 15;
    }
 
    public override double Consumo()
    {
        return vehiculo.Consumo() - 0.4;
    }
}