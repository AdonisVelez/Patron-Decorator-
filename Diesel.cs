public class Diesel : Decorator
{
    // Instancia de la clase vehiculo
    private Vehiculo vehiculo;
 
    // Constructor que recibe el vehículo que encapsulará el decorator
    public Diesel(Vehiculo vehiculo)
    {
        this.vehiculo = vehiculo;
    }
 
    // Los métodos utilizan la información del objeto encapsulado y le
    // incorporan su propia funcionalidad.
    public override string Descripcion()
    {
        return vehiculo.Descripcion() + " Diesel";
    }
 
    public override int VelocidadMaxima()
    {
        return vehiculo.VelocidadMaxima() + 20;
    }
 
    public override double Consumo()
    {
        return vehiculo.Consumo() - 0.8;
    }
}