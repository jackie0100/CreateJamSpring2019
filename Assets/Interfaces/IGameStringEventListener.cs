using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IGameStringEventListener
{
    void OnEventRaised(string arg);
}
