using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Arrest : MonoBehaviour
{
 public float speed = 1f;
    public GameObject handcuffs;
    public Transform Player;
    
    // Start is called before the first frame update
    void Start()
    {
        handcuffs.transform.SetParent(Player);
        handcuffs.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            handcuffs.SetActive(true);
            handcuffs.transform.position = Player.transform.position;
        }
        if (handcuffs.activeSelf == true)
        {
            handcuffs.transform.position =  UnityEngine.Vector3.Lerp(handcuffs.transform.position, Player.transform.position, speed * Time.deltaTime);
        }
    }
}
