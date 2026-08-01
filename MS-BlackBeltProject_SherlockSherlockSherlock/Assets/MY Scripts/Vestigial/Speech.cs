using UnityEngine;

public class Speech : MonoBehaviour
{
    public GameObject ForgetfulSpeech;
    public GameObject ForgetfulBlock;
    public GameObject MurdererSpeech;
    public GameObject MurdererBlock;
    public GameObject StripeySpeech;
    public GameObject StripeyBlock;
    public GameObject BobbySpeech;
    public GameObject BobbyBlock;
    public bool pPressed = false;

    void Start()
    {
        ForgetfulSpeech.SetActive(false);
        ForgetfulBlock.SetActive(false);
        MurdererSpeech.SetActive(false);
        MurdererBlock.SetActive(false);
        StripeySpeech.SetActive(false);
        StripeyBlock.SetActive(false);
        BobbySpeech.SetActive(false);
        BobbyBlock.SetActive(false);
    }

    void KeyPressed()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            pPressed = true;
        }
    }

    void OnTriggerEnter (Collider other)
    {
        Debug.LogError(other.name);
        if(other.name == "Forgetful" && pPressed == true)
        {
            ForgetfulSpeech.SetActive(true);
            ForgetfulBlock.SetActive(true);
        }
        if(other.name == "Murderess" && pPressed == true)
        {
            MurdererSpeech.SetActive(true);
            MurdererBlock.SetActive(true);
        }
        if(other.name == "Spiteful" && pPressed == true)
        {
            StripeySpeech.SetActive(true);
            StripeyBlock.SetActive(true);
        }
        if(other.name == "Cube" && pPressed == true)
        {
            BobbySpeech.SetActive(true);
            BobbyBlock.SetActive(true);
        }
    }
}


