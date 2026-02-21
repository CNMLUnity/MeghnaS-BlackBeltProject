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
    // Start is called before the first frame update
    void Start()
    {
        GoldPrecipitate.SetActive (false);
        SilverSample.SetActive (true);
        SilverPrecipipitate.SetActive (false);
        AquaRegia.SetActive (true);
        SilverSmall.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider other)
    {
        Debug.LogWarning(other.gameObject.name);
        if(other.gameObject.name == SILVER && Input.GetKeyDown("G"))
        {
            SilverSmall.SetActive (true);
            SilverSmall.transform.position = PlayerHand.transform.position;
        }
    }
}
