using Microsoft.Win32.SafeHandles;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int LastLevel;
    void Start()
    {
        StartCoroutine (Restart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Restart ()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene (LastLevel);
    }
}
