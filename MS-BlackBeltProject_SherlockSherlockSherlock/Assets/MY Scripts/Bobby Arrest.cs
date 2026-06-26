using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BobbyArrest : MonoBehaviour
{
    public Arrest arrest;
    public bool hasHandcuffs;
    public int currentScene;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        hasHandcuffs = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(arrest.handcuffs.activeInHierarchy == true)
        {
            hasHandcuffs = true;
            print(hasHandcuffs);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.tag);
        print(hasHandcuffs);
        if(other.gameObject.tag == "Player" && hasHandcuffs == true)
        {
            print("Life is plagued with injustices");
            print(hasHandcuffs);
            //print("Player has collided with handcuffs");
            //print("Player has entered trigger");
            SceneManager.LoadScene(currentScene + 1);
        }
    }
    /*
        Notes from dunedin 

        the player controller can only collide with trigger colliders so set the trap to be is trigger and use is trigger function here
    */
    
}
