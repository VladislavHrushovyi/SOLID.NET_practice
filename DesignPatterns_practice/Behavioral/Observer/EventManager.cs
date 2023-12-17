using System.Collections;

namespace DesignPatterns_practice.Behavioral.Observer;

public class EventManager
{
    private readonly Dictionary<string, List<IEventListener>> _listeners =  new ();

    public void Subscribe(string eventType, IEventListener listener)
    {
        if (!_listeners.TryGetValue(eventType, out var value))
        {
            List<IEventListener> listeners = new() { listener };
            value = listeners;
            _listeners.Add(eventType, value);
            return;
        }

        value.Add(listener);
    }

    public void Unsubscribe(string eventType, IEventListener listener)
    {
        if (_listeners.TryGetValue(eventType,out var value))
        {
            value.Remove(listener);
        }
    }

    public void Notify(string eventType, string data)
    {
        var listenersByEventType = _listeners[eventType];
        foreach (var listener in listenersByEventType)
        {
            listener.Update(data);
        }
    }
}