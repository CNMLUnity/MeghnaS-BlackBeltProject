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
        }

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.LogWarning(other.gameObject.tag);
        Debug.LogWarning(hasHandcuffs);
        if(other.gameObject.tag == "Player" && hasHandcuffs == true && ThreeTimer.elapsedTime > 0)
        {
            SceneManager.LoadScene(currentScene + 1);
        }
        else if (other.gameObject.tag == "Player" && hasHandcuffs == true && ThreeTimer.elapsedTime <= 0)
        {
            SceneManager.LoadScene(12);
        }
    }
}

