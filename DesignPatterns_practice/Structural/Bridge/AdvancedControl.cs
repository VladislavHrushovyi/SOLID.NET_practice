using DesignPatterns_practice.Structural.Bridge.Devices;

namespace DesignPatterns_practice.Structural.Bridge;

public class AdvancedControl(IDevice device) : RemoteControl(device)
{
    public void Mute()
    {
        device.SetVolume(0);
        Console.WriteLine($"{device.GetType().Name} mute action: volume = {device.Volume}");
    }
}