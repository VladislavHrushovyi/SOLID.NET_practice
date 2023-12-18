namespace DesignPatterns_practice.Behavioral.State;

public class AudioPlayer
{
    private readonly AudioPlayerUI _ui;
    private State _state;
    public bool IsPlaying { get; set; }
    public AudioPlayer()
    {
        _state = new ReadyState(this);
        _ui = new AudioPlayerUI();
        _ui.LockButton.OnClick(ClickLock);
        _ui.PlayButton.OnClick(ClickPlay);
        _ui.NextButton.OnClick(ClickNext);
        _ui.PrevButton.OnClick(ClickPrevious);
    }

    public void ChangeState(State state)
    {
        _state = state;
    }

    public void ClickLock()
    {
        _state.ClickLock();
    }

    public void ClickPlay()
    {
        _state.ClickPlay();
    }

    public void ClickNext()
    {
        _state.ClickNext();
    }

    public void ClickPrevious()
    {
        _state.ClickPrevious();
    }
}