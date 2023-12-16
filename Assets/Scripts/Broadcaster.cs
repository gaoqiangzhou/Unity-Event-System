using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broadcaster : MonoBehaviour
{
    public int health;
    [Header("Events")] public GameEvent HealthChangeEvent;
    // Start is called before the first frame update
    void Awake()
    {
        health = 10000;
        StartCoroutine(TakeDamage(1));
    }

    IEnumerator TakeDamage(int amount)
    {
        while(health > 0)
        {
            health = health - amount;
            HealthChangeEvent.Raise(this, health);//pass the sender info and data related
            yield return new WaitForSeconds(1.0f);
        }
    }
}
