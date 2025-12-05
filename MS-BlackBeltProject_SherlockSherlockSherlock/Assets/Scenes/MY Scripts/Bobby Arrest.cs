using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BobbyArrest : MonoBehaviour
{
    public Arrest arrest;
    public bool hasHandcuffs;
    // Start is called before the first frame update
    void Start()
    {
        hasHandcuffs = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(arrest.handcuffs.activeSelf == true)
        {
            hasHandcuffs = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.LogWarning("hi");
        if(collision.gameObject.tag == "Player" && hasHandcuffs == true)
        {
            Debug.LogWarning("Player has collided with handcuffs");
            SceneManager.LoadScene(8);
        }
    }
    /*
        Notes from dunedin 

        the player controller can only collide with trigger colliders so set the trap to be is trigger and use is trigger function here
    */
    
}
