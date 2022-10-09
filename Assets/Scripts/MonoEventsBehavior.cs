
using System;
using System.Transactions;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;
    // Start is called before the first frame update
    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}
