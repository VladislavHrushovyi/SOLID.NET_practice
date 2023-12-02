using DesignPatterns_practice.Creational.Builder.Builders;

namespace DesignPatterns_practice.Creational.Builder;

public class VehicleShop()
{
    public void Construct(VehicleBuilder vehicleBuilder)
    {
        vehicleBuilder.BuildFrame()
            .BuildEngine()
            .BuildWheel()
            .BuildDoors();
    }
}