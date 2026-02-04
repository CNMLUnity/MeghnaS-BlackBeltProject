using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Guard : MonoBehaviour
{
    public GameObject Player;
    public PlayerMove PlayerMove;
    public Spawn spawn;
    public float speed = 10f;
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn.number >= 16)
        {
            agent.SetDestination (Player.transform.position);
            
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && PlayerMove.isKicking == true)
        {

            Debug.LogWarning("Player has deactivated guard.");
        }        

        else if(other.gameObject.tag == "Player" && PlayerMove.isPunching == true)
        {

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
