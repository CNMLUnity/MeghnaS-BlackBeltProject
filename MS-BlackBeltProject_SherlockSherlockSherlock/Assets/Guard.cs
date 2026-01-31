using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Guard : MonoBehaviour
{
    public GameObject Player;
    public PlayerMove PlayerMove;
    public Spawn spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && PlayerMove.isKicking == true)
        {
            gameObject.SetActive(false);
            Invoke("spawn.Update", 0);
            Debug.LogWarning("Player has deactivated guard.");
        }        

        else if(other.gameObject.tag == "Player" && PlayerMove.isPunching == true)
        {
            gameObject.SetActive(false);
            Invoke("spawn.Update", 0);
            Debug.LogWarning("Player has deactivated guard.");
        }
        else if(other.gameObject.tag == "Player")
        {
            Player.SetActive(false);
            SceneManager.LoadScene(9);
            Debug.LogWarning("Player has collided without defense and lost health.");
        }
    }
}
