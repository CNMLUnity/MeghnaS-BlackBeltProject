using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gaspyoudidntsuckaswell : MonoBehaviour
{
    public int currentScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonNotCooked()
    {
        SceneManager.LoadScene(currentScene + 1);
    }
}

