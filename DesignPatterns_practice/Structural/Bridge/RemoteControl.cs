using DesignPatterns_practice.Structural.Bridge.Devices;

namespace DesignPatterns_practice.Structural.Bridge;

public class RemoteControl(IDevice device)
{
    public void TogglePower()
    {
        if (device.IsEnabled)
        {
            device.Disable();
            Console.WriteLine($"{device.GetType().Name} is turn off");
        }
        else
        {
            device.Enable();
            Console.WriteLine($"{device.GetType().Name} is turn on");
        }
    }

    public void VolumeDown()
    {
        Console.WriteLine($"{device.GetType().Name} volume before down action: {device.Volume}");
        device.SetVolume(device.Volume - 10);
        Console.WriteLine($"{device.GetType().Name} volume after down action: {device.Volume}");
    }

    public void VolumeUp()
    {
        Console.WriteLine($"{device.GetType().Name} volume before up action: {device.Volume}");
        device.SetVolume(device.Volume + 10);
        Console.WriteLine($"{device.GetType().Name} volume after up action: {device.Volume}");
    }

    public void ChannelUp()
    {
        Console.WriteLine($"{device.GetType().Name} channel before up action: {device.Channel}");
        device.SetChannel(device.Channel + 1);
        Console.WriteLine($"{device.GetType().Name} channel after up action: {device.Channel}");
    }

    public void ChannelDown()
    {
        Console.WriteLine($"{device.GetType().Name} channel before down action: {device.Channel}");
        device.SetChannel(device.Channel - 1);
        Console.WriteLine($"{device.GetType().Name} channel after down action: {device.Channel}");
    }
}