namespace DesignPatterns_practice.Behavioral.State;

public class StateApplication
{
    public void RunStateScenario()
    {
        var audioPlayerApp = new AudioPlayer();
        audioPlayerApp.ClickLock();
        audioPlayerApp.ClickPlay();
        audioPlayerApp.ClickNext();
        audioPlayerApp.ClickLock();
        audioPlayerApp.ClickNext();
        audioPlayerApp.ClickPrevious();
    }
}