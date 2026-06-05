using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine. SceneManagement;

public class LvlXarrest : MonoBehaviour
{
    public GameObject innocent;
    public GameObject guilty;
    public GameObject telephone;
    public bool telephoneTouched;
    public int currentScene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        telephoneTouched = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.name == "Telephone")
        {
            telephoneTouched = true;
        }
        if (other.gameObject.name == "GuiltyBlock" && telephoneTouched = true)
        {
            SceneManager.LoadScene (21);
        }
        if (other.gameObject.name == "InnocentBlock" && telephoneTouched = true)
        {
            SceneManager.LoadScene (currentScene + 1);
        }
    }
}
