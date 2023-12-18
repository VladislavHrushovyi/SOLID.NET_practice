namespace DesignPatterns_practice.Behavioral.State;

public abstract class State(AudioPlayer audioPlayer)
{
    public abstract void ClickLock();
    public abstract void ClickPlay();
    public abstract void ClickNext();
    public abstract void ClickPrevious();
}