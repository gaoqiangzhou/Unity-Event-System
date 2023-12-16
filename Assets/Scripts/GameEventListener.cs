using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//create a custom event sothat can pass the sender and data change infomation when broadcast a event
[System.Serializable]  public class CustomGameEvent : UnityEvent<Component, object> { }

public class GameEventListener : MonoBehaviour
{
    //the event this game object is listening to
    public GameEvent gameEvent;

    public CustomGameEvent response;

    private void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }
    private void OnDisable()
    {
        gameEvent.UnregisterListener(this);
    }

    //will be called when a event is broadcasted
    public void OnEventRaised(Component sender, object data)
    {
        response.Invoke(sender, data);
    }
}
