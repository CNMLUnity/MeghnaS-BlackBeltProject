using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelephoneArrest : MonoBehaviour
{
    public GameObject guiltyBlock;
    public GameObject innoBlock;
    public GameObject telephone;
    public bool teleTouched;
    public int currentScene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        teleTouched = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Telephone")
        {
            teleTouched = true;
        }
        if (other.name == "InnocentBlock" && teleTouched == true)
        {
            SceneManager.LoadScene (currentScene + 1);
        }
        if (other.name == "GuiltyBlock" && teleTouched == true)
        {
            SceneManager.LoadScene (12);
        }
    }
}
