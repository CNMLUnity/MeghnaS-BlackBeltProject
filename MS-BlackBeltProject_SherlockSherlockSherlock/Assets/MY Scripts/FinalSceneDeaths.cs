using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSceneDeaths : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // OnTriggerEnter is called when the Collider other enters the trigger.
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene (12);
        }
        if (other.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene (1);
        }
    }
}
