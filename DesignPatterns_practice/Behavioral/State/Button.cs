namespace DesignPatterns_practice.Behavioral.State;

public class Button(Action onClickAction = null)
{
    public void OnClick(Action action)
    {
        onClickAction = action;
    }

    public void Click()
    {
        onClickAction.Invoke();
    }
}