using System;
using UnityEngine;

public class PointCollector : MonoBehaviour
{
    [SerializeField] private GameplayScriptable gameplayScriptable;

    private void OnTriggerEnter(Collider other)
    {
        var pickup = other.GetComponent<Pickup>();
        if (!pickup) return;
        
        pickup.Pick();
        gameplayScriptable.score++;
    }

    private void OnCollisionEnter(Collision other)
    {
        var pickup = other.transform.GetComponent<Pickup>();
        if (!pickup) return;
        
        pickup.Pick();
        gameplayScriptable.score++;
    }
}
