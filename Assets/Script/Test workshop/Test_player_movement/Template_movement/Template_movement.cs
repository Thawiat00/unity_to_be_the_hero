using UnityEngine;

public class Template_movement : MonoBehaviour
{
    [SerializeField]
    private CharacterController controller;

    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    private void Awake()
    {
        if (controller == null)
            controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        HandleMovement();
    }

    
    private void HandleMovement()
    {
        // Horizontal input
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 move = Vector3.ClampMagnitude(input, 1f);

        if (move != Vector3.zero)
        {
            transform.forward = move;
        }

        // Apply horizontal movement
        Vector3 horizontalMove = move * playerSpeed;

        // Jump logic
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -2.0f * gravityValue);
        }

        // Apply gravity
        playerVelocity.y += gravityValue * Time.deltaTime;

        // Combine movement
        Vector3 finalMove = horizontalMove + Vector3.up * playerVelocity.y;
        controller.Move(finalMove * Time.deltaTime);

        // Grounded check AFTER Move to avoid missing grounding on slopes or steps
        groundedPlayer = controller.isGrounded;

        // Reset falling velocity when grounded
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = -1f; // Slight downward force to keep grounded
        }
    }




}

