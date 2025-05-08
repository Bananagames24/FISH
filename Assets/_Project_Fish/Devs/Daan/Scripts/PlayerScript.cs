using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour 
{ 
    [Header("Player Movement")]
    [SerializeField] private float speed;
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private float jumpForce = 5f;
    private bool jump = false;

    [Header("Character Controller")]
    public CharacterController characterController;
    private Vector2 input = Vector2.zero;
    Vector3 velocity;

    [SerializeField] private Transform cam;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    void Update()
    {
        HandleMovementAndJump();
        Vector3 camDir = Camera.main.transform.forward;
        camDir.y = 0f;
        transform.forward = camDir;
    }

    void HandleMovementAndJump()
    {
        Vector3 direction = transform.right * input.x + transform.forward * input.y;

        if (characterController.isGrounded)
        {
            if (velocity.y < 0)
            {
                velocity.y = -2f;
            }

            if (jump)
            {
                velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
                jump = false;
            }
        }
        else
        {
            velocity.y += gravity * Time.deltaTime;
        }

        //makes the player move in all directions
        //can only use m.controller.move 1 time in script or the character controller will bug with isgrounded
        Vector3 move = direction * speed * Time.deltaTime + velocity * Time.deltaTime;
        characterController.Move(move);
    }

    public void OnMoveStop(InputAction.CallbackContext _context)
    {
        input = Vector2.zero;
    }

    public void OnMove(InputAction.CallbackContext _context)
    {
        input = _context.ReadValue<Vector2>().normalized;
    }

    public void Jump(InputAction.CallbackContext _context)
    {
        if (_context.performed && characterController.isGrounded)
        {
            jump = true;
        }
    }
}
