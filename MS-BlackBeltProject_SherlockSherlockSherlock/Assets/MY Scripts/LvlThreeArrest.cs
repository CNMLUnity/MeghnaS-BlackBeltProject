using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LvlThreeArrest : MonoBehaviour
{
    public Arrest arrest;
    public bool hasHandcuffs;
    public int currentScene;
    // Start is called before the first frame update
    public LvlThreeTimer ThreeTimer;
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        hasHandcuffs = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(arrest.handcuffs.activeSelf == true)
        {
            hasHandcuffs = true;
            Debug.Log(hasHandcuffs);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.LogWarning(other.gameObject.tag);
        Debug.LogWarning(hasHandcuffs);
        if(other.gameObject.tag == "Player" && hasHandcuffs == true && ThreeTimer.elapsedTime > 0)
        {
            Debug.LogWarning(hasHandcuffs);
            //Debug.LogWarning("Player has collided with handcuffs");
            Debug.LogError("Player has entered trigger");
            SceneManager.LoadScene(currentScene + 1);
        }
        else if (other.gameObject.tag == "Player" && hasHandcuffs == true && ThreeTimer.elapsedTime <= 0)
        {
            SceneManager.LoadScene(21);
        }
    }
    /*
        Notes from dunedin 

        the player controller can only collide with trigger colliders so set the trap to be is trigger and use is trigger function here
    */
    
}

