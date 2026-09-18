using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    public bool isPunching;
    public bool isKicking;
    [Header("Camera")]
    public Transform camTransform;
    public float sensitivity = 2f;

    public GameObject lookTarget;

    private float cameraRotX;

    private float pushPower = 2.0f;

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

    void Update()
    {
        float horizontalInput = -Input.GetAxis("Horizontal") * speed;
        float verticalInput = Input.GetAxis("Vertical") * speed;
        gug += verticalInput;
        if(!controller.isGrounded)
        {
            //gag is the codon for glutamine
            gag -= 15f * Time.deltaTime;
        }
        else if(Input.GetKeyDown("space"))
        {
            gag = 10;
            yo.SetTrigger("JUmp");

        }
        Vector3 move = playerTransform.forward * verticalInput + playerTransform.right * -horizontalInput;
        yo.SetFloat("Speed", move.magnitude);
        move += new Vector3(0.0f, gag, 0.0f);
        controller.Move(move * Time.deltaTime);

        if(Input.GetKeyDown("space"))
        {
            RaycastHit hit;
            if(Physics.SphereCast(transform.position, 0.008f, transform.up * -1, out hit, 2))
            {
                
            }
        }
        if(transform.position.y > floor.transform.position.y)
        {
           
        }
        if(transform.position.y < floor.transform.position.y)
        {
            SceneManager.LoadScene(12);
        }

        //CONNECTS MOUSE TO CAMERA
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;
        // Accumulate rotation
        
        cameraRotX -= mouseY;
        cameraRotX = Mathf.Clamp(cameraRotX, -75f, 75f);

        lookTarget.transform.localRotation = Quaternion.Euler(cameraRotX, 0.0f, 0.0f);

        transform.Rotate(0f, mouseX, 0f);

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
            yo.SetTrigger("Aaa...");
            controller.Move(Vector3.down * 5 * Time.deltaTime);
            speed = 0f;
            gag = 0f;
        }
    }
    void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Water"))
        {
            SceneManager.LoadScene(2);
        }
        if(isKicking && other.CompareTag("Guard"))
        {
            Destroy(other);
        }
        if(isPunching && other.CompareTag("Guard"))
        {
            Destroy(other);
        }
    }
    //  void OnControllerColliderHit(ControllerColliderHit hit)
    // {
    //     Rigidbody body = hit.collider.attachedRigidbody;

    //     // no rigidbody
    //     if (body == null || body.isKinematic)
    //     {
    //         return;
    //     }

    //     // We dont want to push objects below us
    //     if (hit.moveDirection.y < -0.3)
    //     {
    //         return;
    //     }

    //     // Calculate push direction from move direction,
    //     // we only push objects to the sides never up and down
    //     Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

    //     // If you know how fast your character is trying to move,
    //     // then you can also multiply the push velocity by that.

    //     // Apply the push
    //     body.linearVelocity = pushDir * pushPower;
    // }
}
//This comment will fix the camera because it is writtent by me the great.
