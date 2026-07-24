using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MomoMove : MonoBehaviour
{
    public GameObject Player;
    public PlayerMove PlayerMove;
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
        agent.SetDestination (Player.transform.position);
        Debug.Log(agent.destination);
    }
}
