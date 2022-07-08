public abstract class Decorator : Vehiculo
{
    // Declaramos el método como abstracto para que todos los decoradores lo
    // reimplementen.
    public override abstract string Descripcion();
}