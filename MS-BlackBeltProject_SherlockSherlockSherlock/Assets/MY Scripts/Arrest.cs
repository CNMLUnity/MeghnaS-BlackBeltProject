using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Arrest : MonoBehaviour
{
    public Transform target;
    public float speed = 1f;
    public GameObject handcuffs;
    public Transform Player;
    //public UnityEngine.Vector3 handOffset = new UnityEngine.Vector3(0f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        //handcuffs.transform.SetParent(Player);
        handcuffs.SetActive(false);
        Debug.Log(handcuffs.activeInHierarchy);
        //Debug.Log("The player's position is" + Player.transform.position + "The handcuffs position is" +  handcuffs.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            //handcuffs.transform.position = Player.transform.position;
            Debug.Log("Vai is dis scamming me");
            handcuffs.SetActive(true);
            Debug.Log(handcuffs.activeSelf);
            //handcuffs.transform.localPosition = new Vector3(0f,1.2f,0f);
        }
        if (handcuffs.activeSelf == true)
        {
            handcuffs.transform.position =  UnityEngine.Vector3.Lerp(handcuffs.transform.position, Player.transform.position, speed * Time.deltaTime);
            //transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
            Debug.Log("The player's position is" + Player.transform.position + "The handcuffs position is" +  handcuffs.transform.position);
        }
    }
}
