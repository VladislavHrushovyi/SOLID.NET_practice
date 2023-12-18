namespace DesignPatterns_practice.Behavioral.State;

public class PlayingState(AudioPlayer audioPlayer) : State(audioPlayer)
{
    public override void ClickLock()
    {
        audioPlayer.ChangeState(new LockedState(audioPlayer));
        Console.WriteLine($"{this.GetType().Name}: click lock action locked state");
    }

    public override void ClickPlay()
    {
        Console.WriteLine($"{this.GetType().Name}: click play action stopPlayback()");
        audioPlayer.ChangeState(new ReadyState(audioPlayer));
    }

    public override void ClickNext()
    {
        if (Random.Shared.Next(0,10) > 5)
        {
            Console.WriteLine($"{this.GetType().Name}: click next action nextSong()");
        }
        else
        {
            Console.WriteLine($"{this.GetType().Name}: click next action fastForward(5)");
        }
    }

    public override void ClickPrevious()
    {
        if (Random.Shared.Next(0,10) > 5)
        {
            Console.WriteLine($"{this.GetType().Name}: click prev action previous()");
        }
        else
        {
            Console.WriteLine($"{this.GetType().Name}: click next action rewind(5)");
        }
    }
}