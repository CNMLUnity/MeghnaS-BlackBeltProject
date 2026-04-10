using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLUSONE : MonoBehaviour
{
    public float currentScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ClickButton ()
    {
        SceneManager.LoadScene("currentScene" + 1);
    }
}
