using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;

public class YouSuck : MonoBehaviour
{
    public int currentScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ButtonCicked()
    {
        SceneManager.LoadScene (12);
        StartCoroutine(WaitRoutine());
    }
    IEnumerator WaitRoutine()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene (currentScene);
    }

}
