using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public GameObject AquaRegia;
    public GameObject SilverPrecipipitate;
    public GameObject GoldPrecipitate;
    public GameObject SilverSample;
    public GameObject SilverSmall;
    public GameObject PlayerHand;
    public bool isTouchingSilver;
    public bool isTouchingCircle;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        GoldPrecipitate.SetActive (false);
        SilverSample.SetActive (true);
        SilverPrecipipitate.SetActive (false);
        AquaRegia.SetActive (true);
        SilverSmall.SetActive(false);
        isTouchingSilver = false;
        isTouchingCircle = false;
    }
    void OnTriggerEnter (Collider other)
    {
        Debug.LogWarning(other.gameObject.name);
        if(other.gameObject.name == "Circle")
        {
            isTouchingCircle = true;
        }
    }
    // Update is called once per frame
    void Update()
    {        
        if(isTouchingSilver = true && Input.GetKeyDown(KeyCode.G))
        {
            Debug.LogError("You have pressed G.");
            SilverSmall.SetActive(true);
            //isTouchingSilver = true;
            
        }
        if (SilverSmall.activeInHierarchy)
        {
            SilverSmall.transform.position = PlayerHand.transform.position; //UnityEngine.Vector3.Lerp(SilverSmall.transform.position, PlayerHand.transform.position, speed * Time.deltaTime);;
        }
        if(isTouchingCircle = true && Input.GetKeyDown(KeyCode.R))
        {
            SilverSmall.SetActive(false);
            AquaRegia.SetActive(false);
            GoldPrecipitate.SetActive(true);
            SilverPrecipipitate.SetActive(true);
        }
    }
}
