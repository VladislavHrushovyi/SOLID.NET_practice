using DesignPatterns_practice.Creational.Builder.Builders;

namespace DesignPatterns_practice.Creational.Builder;

public class BuilderApplication
{
    public void RunBuilderScenario()
    {
        VehicleBuilder vehicleBuilder;

        VehicleShop shop = new VehicleShop();
        
        vehicleBuilder = new ScooterBuilder();
        shop.Construct(vehicleBuilder);
        vehicleBuilder.Vehicle.Show();
        
        vehicleBuilder = new MotorCycleBuilder();
        shop.Construct(vehicleBuilder);
        vehicleBuilder.Vehicle.Show();
        
        vehicleBuilder = new CarBuilder();
        shop.Construct(vehicleBuilder);
        vehicleBuilder.Vehicle.Show();
    }
}