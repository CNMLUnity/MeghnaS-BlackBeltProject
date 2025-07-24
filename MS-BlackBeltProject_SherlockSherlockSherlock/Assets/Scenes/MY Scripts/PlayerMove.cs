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
    public Rigidbody rb;

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


        // Jump
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -2.0f * gravityValue);
        }

        // Apply gravity
        //playerVelocity.y += gravityValue * Time.deltaTime;

        // Combine horizontal and vertical movement
        float horInput = Input.GetAxisRaw("Horizontal") * playerSpeed;
        float verInput = Input.GetAxisRaw("Vertical") * playerSpeed;

        // camera dir
        Vector3 camForward = cameraTransform.forward;
        Vector3 camRight = cameraTransform.right;

        camForward.y = 0;
        camRight.y = 0;

        Debug.DrawRay(transform.position, camForward * 40, Color.red);
        Debug.DrawRay(transform.position, camRight * 40, Color.green);

        Vector3 forwardRelative = verInput * camForward;
        Vector3 rightRelative = horInput * camRight;


        Vector3 moveDir = forwardRelative + rightRelative;

        Debug.DrawRay(transform.position, moveDir * 40, Color.blue);

        controller.Move(moveDir);
        gameObject.transform.rotation = Quaternion.Euler(moveDir);

        

    }
}
