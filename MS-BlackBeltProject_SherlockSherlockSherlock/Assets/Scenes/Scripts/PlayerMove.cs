using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 playerVelocity;
    public bool groundedPlayer;
    public float playerSpeed = 2.0f;
    public float jumpHeight = 1.0f;
    public float gravityValue = -9.81f;
    public Transform cameraTransform;
    public float horizontalSpeed = 5.0f;
    public float verticalSpeed = 5.0f;
    public Vector3 dirVector;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {

        
        //groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        if(Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        // Horizontal input
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        move = Vector3.ClampMagnitude(move, 1f); // Optional: prevents faster diagonal movement

        if (move != Vector3.zero)
        {
            cameraTransform.forward = move;
        }

        // Jump
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -2.0f * gravityValue);
        }

        // Apply gravity
        playerVelocity.y += gravityValue * Time.deltaTime;

        // Combine horizontal and vertical movement


        if(Input.GetKeyDown("w")){
            dirVector = cameraTransform.forward;
        } else if (Input.GetKeyDown("s")) {
            dirVector = -cameraTransform.forward;
        }

        Vector3 finalMove = (dirVector * playerSpeed * move.z) + (playerVelocity.y * Vector3.up);
        controller.Move(finalMove * Time.deltaTime);
    }
}
