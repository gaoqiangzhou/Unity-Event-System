using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiverBehavior : MonoBehaviour
{
    public void ReactiontoHealthChange(Component sender, object data)
    {
        //e.g. if sender is Broadcaster then ....
        if(data is int)
        {
            Debug.Log($"current health is {data}");
        }
       
    }
}
