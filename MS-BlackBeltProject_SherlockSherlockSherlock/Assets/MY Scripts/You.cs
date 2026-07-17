using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTrigger(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            print("You lose!");
            SceneManager.LoadScene(2);
        }
    }

}
