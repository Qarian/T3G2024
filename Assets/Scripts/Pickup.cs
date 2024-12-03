using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class Pickup : MonoBehaviour
{
    public UnityEvent callback;

    private Animator animator;

    public Animator Animator => animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
}