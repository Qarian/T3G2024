using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class BallController : MonoBehaviour
{
    [SerializeField]
    private float force;
    [SerializeField]
    private float jumpForce;
    
    new Rigidbody rigidbody;
    private BallActions input;
    private Camera camera;
    private Vector2 moveDirection;
    private bool jump;
    
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        input = new BallActions();
        input.Enable();

        input.Player.Jump.performed += Jump;

        camera = Camera.main;
    }

    private void Jump(InputAction.CallbackContext _)
    {
        jump = true;
    }

    private void Update()
    {
        moveDirection = input.Player.Move.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        Vector3 moveVector = DirectionBasedOnCamera(moveDirection) * force;
        rigidbody.AddForce(moveVector);
        if (jump)
        {
            rigidbody.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
            jump = false;
        }
    }

    private Vector3 DirectionBasedOnCamera(Vector2 input)
    {
        Transform cameraTransform = camera.transform;
        var forward = cameraTransform.forward;
        forward.y = 0;
        forward.Normalize();
        
        var right = cameraTransform.right;
        right.y = 0;
        right.Normalize();
        
        return (forward * input.y + right * input.x).normalized;
    }
}
