using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEvent", menuName = "GameEvent", order = 0)]
public class GameEvent : ScriptableObject
{
    public List<GameEventListener> Listeners = new();

    public void Raise()
    {
        foreach (var listener in Listeners)
        {
            listener.OnEventRaised();
        }
    }

    public void RegisterListener(GameEventListener listener)
    {
        if (!Listeners.Contains(listener))
            Listeners.Add(listener);
    }

    public void UnregisterListener(GameEventListener listener)
    {
        if (Listeners.Contains(listener))
            Listeners.Remove(listener);
    }

}
