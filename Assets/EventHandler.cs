using UnityEngine;
using UnityEngine.Events;

public class EventHandler : MonoBehaviour
{
    public UnityEvent onCollisionEnter;
    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;
    public UnityEvent onEnable;
    public UnityEvent onDisable;

    public void OnTriggerEnter(Collider other)
    {
        onTriggerEnter.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        onTriggerExit.Invoke();
    }

    private void OnCollisionEnter(Collision other)
    {
        onCollisionEnter.Invoke();
    }
    
    private void OnEnable()
    {
        onEnable.Invoke();
    }
    
    private void OnDisable()
    {
        onDisable.Invoke();
    }
}
