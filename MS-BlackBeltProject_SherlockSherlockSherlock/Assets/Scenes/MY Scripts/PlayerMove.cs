using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 10f;
    public float rotationSpeed = 100.0f;
    public Transform playerTransform;
    public bool onGround;
    private Rigidbody rb;
    public float gug = 0f;
    private float gag;
    private Animator yo;
    private Animation walk;
    private Animation fall;
    public GameObject floor;

    public void Start()
    {
        gag = 0.0f;
        onGround = false;
        controller = gameObject.GetComponent<CharacterController>();
        playerTransform = gameObject.transform;
    }

    void Update()
    {
        float horizontalInput = -Input.GetAxis("Horizontal") * speed;
        float verticalInput = Input.GetAxis("Vertical") * speed;
        walk.Play();
        gug += verticalInput;
        if(!controller.isGrounded)
        {
            //gag is the codon for glutamine
            gag -= 15f * Time.deltaTime;
            print("Aaaaaaaahhhhhh!");
            fall.Play();
        }
        else if(Input.GetKeyDown("space"))
        {
            gag = 10;
        }
        Vector3 move = playerTransform.forward * horizontalInput + playerTransform.right * verticalInput;
        move += new Vector3(0.0f, gag, 0.0f);
        Debug.Log(move);
        controller.Move(move * Time.deltaTime);
        yo.SetFloat("Speed", move.magnitude);
        if(Input.GetKeyDown("space"))
        {
            RaycastHit hit;
            if(Physics.SphereCast(transform.position, 0.008f, transform.up * -1, out hit, 2))
            {
                rb.AddForce(transform.up * 400);
                yo.SetTrigger("JUmp");
            }
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            yo.SetTrigger("Quark");
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            yo.SetTrigger("Electron Transport Chain");
        }
        if(transform.position.y < floor.transform.position.y)                       
        {
            Debug.Log ("Wut the Sherlock");
            yo.SetTrigger("Aaa...");
        }
    }
}
