using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class Pickup : MonoBehaviour
{
    [SerializeField]
    private  UnityEvent callback;

    private Animator animator;
    public Animator Animator => animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Pick()
    {
        Animator.SetTrigger("Pick");
        //pickup.Animator.Play("Pickup Destroy");
        callback.Invoke();
    }
}