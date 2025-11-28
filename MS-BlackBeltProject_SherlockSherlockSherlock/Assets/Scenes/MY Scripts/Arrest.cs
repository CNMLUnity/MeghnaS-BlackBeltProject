using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrest : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public GameObject handcuffs;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        handcuffs.SetActive(false);
        Debug.Log(handcuffs.activeInHierarchy);
        Debug.Log("The player's position is" + Player.transform.position + "The handcuffs position is" +  handcuffs.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            handcuffs.transform.position = Player.transform.position;
            handcuffs.SetActive(true);
        }
        if (handcuffs.activeSelf)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
