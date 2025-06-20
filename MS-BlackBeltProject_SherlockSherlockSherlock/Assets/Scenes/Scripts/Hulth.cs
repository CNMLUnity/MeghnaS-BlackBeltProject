using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hulth : MonoBehaviour
{
    public GameObject [] hearts;
    public int lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider other)
    {
        print("aaaaaaa");
        if(other.gameObject.tag == "Trap")
        {
            lives = 0;
            LoadScene();
            print("You suck");
        }
    }
    void LoadScene()
    {
        SceneManager.LoadScene(3);
        Invoke("Lose", 3);
    }
    void Lose ()
    {
        SceneManager.LoadScene(2);
    }
}
