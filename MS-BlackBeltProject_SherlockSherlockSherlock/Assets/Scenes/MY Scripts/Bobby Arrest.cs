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
        if(arrest.handcuffs.SetActive(true))
        {
            hasHandcuffs = true;
        }
    }
    void OnCollisionEnter (Collision collision)
    {
        if(collision.gameObject.tag == "Player" && hasHandcuffs == true)
        {
             SceneManager.LoadScene(8);
        }
    }
}
