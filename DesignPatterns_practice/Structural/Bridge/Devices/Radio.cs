namespace DesignPatterns_practice.Structural.Bridge.Devices;

public sealed class Radio : IDevice
{
    public int Volume { get; private set; } = 30;
    public int Channel { get; private set; } = 200;
    public bool IsEnabled { get; set; }
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
        if (channel is >= 185 and <= 220)
        {
            Channel = channel;
        }
    }
}