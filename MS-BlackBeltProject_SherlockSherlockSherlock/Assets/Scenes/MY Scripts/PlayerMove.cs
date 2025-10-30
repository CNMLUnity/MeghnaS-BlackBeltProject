using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public float health = 1;

    public void Start()
    {
        gag = 0.0f;
        onGround = false;
        controller = gameObject.GetComponent<CharacterController>();
        playerTransform = gameObject.transform;
        yo = GetComponent<Animator>();
        yo.SetBool("JUmp", false);
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
                rb.AddForce(transform.up * 400);
            }
        }
        if(transform.position.y > floor.transform.position.y)
        {
            //yo.SetBool("JUmp", true);
        }
        //else if (transform.position.y = floor.transform.position.y)
        //{
//            yo.SetBool("JUmp", false);
        //}
        if(Input.GetKeyDown(KeyCode.Q))
        {
            yo.SetTrigger("Quark");
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            yo.SetTrigger("Electron Transport Chain");
        }
        if (transform.position.y < floor.transform.position.y)
        {
            Debug.Log("Wut the Sherlock");
            yo.SetTrigger("Aaa...");
            //Invoke("Dead", 5);
        }
    if (move.z < 0)
    {
        yo.SetTrigger("deeKlunk");
    }
    if(move.x > 0)
    {
      yo.SetTrigger("Lambeosaurus");
    }
    }
   // void Dead()
    //{
    //    SceneManager.LoadScene(2);
    //}
}
