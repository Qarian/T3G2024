using System;
using UnityEngine;

public class PointCollector : MonoBehaviour
{
    [SerializeField] private GameplayScriptable gameplayScriptable;

    private void Start()
    {
        gameplayScriptable.score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        var pickup = other.GetComponent<Pickup>();
        if (!pickup) return;
        
        pickup.callback.Invoke();
        pickup.Animator.SetTrigger("Pick");
        //pickup.Animator.Play("Pickup Destroy");
        gameplayScriptable.score++;
    }

    private void OnCollisionEnter(Collision other)
    {
        var pickup = other.transform.GetComponent<Pickup>();
        if (!pickup) return;
        
        Destroy(pickup.gameObject);
        gameplayScriptable.score++;
    }
}
