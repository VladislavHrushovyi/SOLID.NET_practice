namespace DesignPatterns_practice.Behavioral.State;

public class ReadyState(AudioPlayer audioPlayer) : State(audioPlayer)
{
    public override void ClickLock()
    {
        audioPlayer.ChangeState(new LockedState(audioPlayer));
    }

    public override void ClickPlay()
    {
        audioPlayer.ChangeState(new ReadyState(audioPlayer));
        Console.WriteLine($"{this.GetType().Name} starting playback");
    }

    public override void ClickNext()
    {
        Console.WriteLine($"{this.GetType().Name}: click Next action nextSong()");
    }

    public override void ClickPrevious()
    {
        Console.WriteLine($"{this.GetType().Name}: click prev action prevSong()");
    }
}