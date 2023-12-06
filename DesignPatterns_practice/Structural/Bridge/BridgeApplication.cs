using DesignPatterns_practice.Structural.Bridge.Devices;

namespace DesignPatterns_practice.Structural.Bridge;

public class BridgeApplication
{
    public void RunBridgeScenario()
    {
        List<RemoteControl> remoteControls = new()
        {
            new RemoteControl(new Radio()),
            new AdvancedControl(new Tv())
        };

        foreach (var control in remoteControls)
        {
            control.TogglePower();
            control.VolumeUp();
            control.ChannelDown();
            control.ChannelUp();
            control.VolumeDown();
            if (control is AdvancedControl adControl)
            {
                adControl.Mute();
            }
            control.TogglePower();
        }
    }
}