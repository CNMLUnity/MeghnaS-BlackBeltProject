using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    // Update is called once per frame
    void OnTrigger(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            print("You lose!");
            SceneManager.LoadScene(12);
        }
    }

}
