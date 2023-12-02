namespace DesignPatterns_practice.Creational.Builder.Builders;

public class ScooterBuilder : VehicleBuilder
{
    public ScooterBuilder()
    {
        _vehicle = new Vehicle("Honda Dio Turbo");
    }
    public override VehicleBuilder BuildFrame()
    {
        _vehicle["frame"] = "Scooter frame";

        return this;
    }

    public override VehicleBuilder BuildEngine()
    {
        _vehicle["engine"] = "75cc";
        
        return this;
    }

    public override VehicleBuilder BuildWheel()
    {
        _vehicle["wheels"] = "2";
        
        return this;
    }

    public override VehicleBuilder BuildDoors()
    {
        _vehicle["doors"] = "0";

        return this;
    }
}