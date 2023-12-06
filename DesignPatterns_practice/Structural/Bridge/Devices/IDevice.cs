namespace DesignPatterns_practice.Structural.Bridge.Devices;

public interface IDevice
{
    public int Volume { get; }
    public int Channel { get; }
    public bool IsEnabled { get; set; }
    public void Enable();
    public void Disable();
    public void SetVolume(int volume);
    public void SetChannel(int channel);
}