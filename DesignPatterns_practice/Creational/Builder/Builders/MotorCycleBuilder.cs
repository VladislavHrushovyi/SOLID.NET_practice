namespace DesignPatterns_practice.Creational.Builder.Builders;

public class MotorCycleBuilder : VehicleBuilder
{
    public MotorCycleBuilder()
    {
        _vehicle = new Vehicle("Kavazaki");
    }
    public override VehicleBuilder BuildFrame()
    {
        _vehicle["frame"] = "Motor Cycle frame";
        
        return this;
    }

    public override VehicleBuilder BuildEngine()
    {
        _vehicle["engine"] = "1200cc";
        
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