using UnityEngine;

public class ShowMessage : MonoBehaviour
{
    public GameObject ForgetfulBlock;
    public GameObject ForgetfulText;
    public GameObject MurderBlock;
    public GameObject MurderText;
    public GameObject SpitefulBlock;
    public GameObject SpitefulText;
    public GameObject BobbyBlock;
    public GameObject BobbyText;

    void Start ()
    {
        ForgetfulBlock.SetActive(false);
        ForgetfulText.SetActive(false);
        MurderBlock.SetActive(false);
        MurderText.SetActive(false);
        SpitefulBlock.SetActive(false);
        SpitefulText.SetActive(false);
        BobbyBlock.SetActive(false);
        BobbyText.SetActive(false);
    }
}
