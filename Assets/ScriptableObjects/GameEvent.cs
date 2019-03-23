using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu( menuName = "ScriptableObjects/GameEvent" )]
public class GameEvent : ScriptableObject
{
    private List<IGameEventListener> _listeners = new List<IGameEventListener>();

    public void Invoke()
    {
        for (int i = _listeners.Count - 1; i >= 0; i--)
        {
            _listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(IGameEventListener listener)
    {
        _listeners.Add(listener);
    }

    public void UnregisterListener(IGameEventListener listener)
    {
        _listeners.Remove(listener);
    }
}
