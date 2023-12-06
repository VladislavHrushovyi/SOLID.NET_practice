namespace DesignPatterns_practice.Structural.Bridge.Devices;

public sealed class Tv : IDevice
{
    public int Volume { get; private set; } = 50;
    public int Channel { get; private set; } = 5;
    public bool IsEnabled { get; set; } = false;
    public void Enable()
    {
        if (!IsEnabled)
        {
            IsEnabled = true;
        }
    }

    public void Disable()
    {
        if (IsEnabled)
        {
            IsEnabled = false;
        }
    }

    public void SetVolume(int volume)
    {
        if (volume is >= 0 and <= 100)
        {
            Volume = volume;
        }
    }

    public void SetChannel(int channel)
    {
        if (channel is >= 0 and <= 20)
        {
            Channel = channel;
        }
    }
}