namespace DesignPatterns_practice.Creational.Builder.Builders;

public abstract class VehicleBuilder
{
    protected Vehicle _vehicle;

    public Vehicle Vehicle => _vehicle;

    public abstract VehicleBuilder BuildFrame();
    public abstract VehicleBuilder BuildEngine();
    public abstract VehicleBuilder BuildWheel();
    public abstract VehicleBuilder BuildDoors();
}