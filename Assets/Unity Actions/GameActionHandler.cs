using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionobj;
    public UnityEvent OnRaiseEvent;

    private void Start()
    {
        gameActionobj.raise += Raise;
    }

    private void Raise()
    {
        OnRaiseEvent.Invoke();
    }
}
