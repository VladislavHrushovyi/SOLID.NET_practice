namespace DesignPatterns_practice.Behavioral.State;

public class LockedState(AudioPlayer audioPlayer) : State(audioPlayer)
{
    public override void ClickLock()
    {
        if (audioPlayer.IsPlaying)
            audioPlayer.ChangeState(new PlayingState(audioPlayer));
        else
            audioPlayer.ChangeState(new ReadyState(audioPlayer));
        Console.WriteLine($"{this.GetType().Name}: click lock");
    }

    public override void ClickPlay()
    {
        Console.WriteLine($"{this.GetType().Name}: click play action nothing");
    }

    public override void ClickNext()
    {
        Console.WriteLine($"{this.GetType().Name}: click next action nothing");
    }

    public override void ClickPrevious()
    {
        Console.WriteLine($"{this.GetType().Name}: click prev action nothing");
    }
}