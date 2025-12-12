using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [Header("PLAYER MOVEMENT")]
    public CharacterController controller;
    public float speed = 10f;
    public float rotationSpeed = 100.0f;
    public Transform playerTransform;
    public bool onGround;
    private Rigidbody rb;
    public float gug = 0f;
    [Header("Animations")]
    private float gag;
    private Animator yo;
    private Animation walk;
    private Animation fall;
    public GameObject floor;
    //public float health = 1;
    public bool isPunching;
    public bool isKicking;
    [Header("Camera")]
    public Transform camTransform;
    public float sensitivity = 2f; // Adjust sensitivity as needed

    public GameObject lookTarget;

    private float cameraRotX;


    void Start()
    {
        gag = 0.0f;
        onGround = false;
        controller = gameObject.GetComponent<CharacterController>();
        playerTransform = gameObject.transform;
        yo = GetComponent<Animator>();
        yo.SetBool("JUmp", false);
        isPunching = false;
        isKicking = false;
    }
//sffsdf
    void Update()
    {
        float horizontalInput = -Input.GetAxis("Horizontal") * speed;
        float verticalInput = Input.GetAxis("Vertical") * speed;
        gug += verticalInput;
        if(!controller.isGrounded)
        {
            //gag is the codon for glutamine
            gag -= 15f * Time.deltaTime;
            print("Aaaaaaaahhhhhh!");
        }
        else if(Input.GetKeyDown("space"))
        {
            gag = 10;
            yo.SetTrigger("JUmp");

        }
        Vector3 move = playerTransform.forward * verticalInput + playerTransform.right * -horizontalInput;
        //print(move);
        Debug.Log(move.normalized);
        yo.SetFloat("Speed", move.magnitude);
        move += new Vector3(0.0f, gag, 0.0f);
        controller.Move(move * Time.deltaTime);
        print(horizontalInput);

        if(Input.GetKeyDown("space"))
        {
            RaycastHit hit;
            if(Physics.SphereCast(transform.position, 0.008f, transform.up * -1, out hit, 2))
            {
                //rb.AddForce(transform.up * 400);
            }
        }
        if(transform.position.y > floor.transform.position.y)
        {
            //yo.SetBool("JUmp", true);
        }
        //else if (transform.position.y = floor.transform.position.y)
        //{
        //yo.SetBool("JUmp", false);
        //}

        //CONNECTS MOUSE TO CAMERA
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;
        // Accumulate rotation

        // Clamp vertical rotation to prevent flipping
        // mouseY = Mathf.Clamp(mouseY, -90f, 90f);
        // Apply rotation to the camera's transform
        // transform.localRotation = Quaternion.Euler(0f, rotationY, 0f); 
        // transform.Rotate(-90f, mouseY, 90f);
        
        cameraRotX -= mouseY;
        cameraRotX = Mathf.Clamp(cameraRotX, -45f, 45f);
        // Accumulate Yaw (Y-axis)
        // cameraRotY += mouseX; // Accumulate horizontal movement
        // Apply BOTH rotations to the SAME camera Transform
        // transform.localRotation = Quaternion.Euler(cameraRotX, cameraRotY, 0.0f);

        lookTarget.transform.localRotation = Quaternion.Euler(cameraRotX, 0.0f, 0.0f);

        transform.Rotate(0f, mouseX, 0f);
        //CONNECTS PLAYER TO CAMERA POSITION
        // if (camTransform != null)
        //     {
        //         // Get the camera's Y-axis rotation (yaw)
        //         float cameraYaw = camTransform.eulerAngles.y;
        //         // Create a new rotation for the player based on the camera's yaw
        //         Quaternion targetRotation = Quaternion.Euler(0f, cameraYaw, 0f);
        //         // Smoothly rotate the player towards the target rotation
        //         transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
        //     }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            yo.SetTrigger("Quark");
            isPunching = true;
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            yo.SetTrigger("Electron Transport Chain");
            isKicking = true;
        }
        if (transform.position.y < floor.transform.position.y)
        {
            Debug.Log("Wut the Sherlock");
            yo.SetTrigger("Aaa...");
            //Invoke("Dead", 5);
        }
    }
   // void Dead()
    //{
    //    SceneManager.LoadScene(2);
    //}
}
//This comment will fix the camera because it is writtent by me the great.
