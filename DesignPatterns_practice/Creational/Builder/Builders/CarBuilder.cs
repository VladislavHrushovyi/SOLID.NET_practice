namespace DesignPatterns_practice.Creational.Builder.Builders;

public class CarBuilder : VehicleBuilder
{
    public CarBuilder()
    {
        _vehicle = new Vehicle("Subaru Impreza STI");
    }
    public override VehicleBuilder BuildFrame()
    {
        _vehicle["frame"] = "Car frame";
        
        return this;
    }

    public override VehicleBuilder BuildEngine()
    {
        _vehicle["engine"] = "2500cc";
        
        return this;
    }

    public override VehicleBuilder BuildWheel()
    {
        _vehicle["wheels"] = "4";
        
        return this;
    }

    public override VehicleBuilder BuildDoors()
    {
        _vehicle["doors"] = "0";
        
        return this;
    }
}