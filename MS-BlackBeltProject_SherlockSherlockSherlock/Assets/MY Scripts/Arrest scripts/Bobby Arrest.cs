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
    public int currentScene = 6;
    // Start is called before the first frame update
    void Start()
    {
        hasHandcuffs = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(arrest.handcuffs.activeInHierarchy == true)
        {
            hasHandcuffs = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {    
        if(other.gameObject.tag == "Player" && hasHandcuffs == true)
        {
            SceneManager.LoadScene(currentScene + 1);
        }
    }
}
