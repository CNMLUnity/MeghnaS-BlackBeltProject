using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gaspyoudidntsuck : MonoBehaviour
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
    public void ButtonNotCicked()
    {
        SceneManager.LoadScene(currentScene + 1);
    }
}
