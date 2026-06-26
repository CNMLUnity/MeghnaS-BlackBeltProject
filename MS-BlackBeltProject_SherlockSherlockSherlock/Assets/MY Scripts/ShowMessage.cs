using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowMessage : MonoBehaviour
{
    public int currentScene;
    public GameObject ForgetfulBlock;
    public GameObject ForgetfulText;
    public GameObject MurderBlock;
    public GameObject MurderText;
    public GameObject SpitefulBlock;
    public GameObject SpitefulText;
    public GameObject BobbyBlock;
    public GameObject BobbyText;
    public Arrest arrest;

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
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        if(other.gameObject.name == "Murderess" && Input.GetKeyDown(KeyCode.P))
        {
            MurderBlock.SetActive(true);
            MurderText.SetActive(true);
            Debug.LogWarning(MurderBlock, MurderText);
        }
        if(other.gameObject.name == "Forgetful" && Input.GetKeyDown(KeyCode.P))
        {
            ForgetfulBlock.SetActive(true);
            ForgetfulText.SetActive(true);
            Debug.LogWarning(ForgetfulBlock, ForgetfulText);
        }
        if(other.gameObject.name == "Spiteful" && Input.GetKeyDown(KeyCode.P))
        {
            print("hi");
            SpitefulBlock.SetActive(true);
            SpitefulText.SetActive(true);
            Debug.LogWarning(SpitefulBlock, SpitefulText);
        }
        if(other.gameObject.name == "Bobby" && Input.GetKeyDown(KeyCode.P))
        {
            BobbyBlock.SetActive(true);
            BobbyText.SetActive(true);
            Debug.LogWarning(BobbyBlock, BobbyText);
        }
        if(other.gameObject.name == "Murderess" && arrest.handcuffs.activeInHierarchy == true)
        {
            SceneManager.LoadScene(currentScene + 1);
        }
        if(other.gameObject.name != "Murderess" && arrest.handcuffs.activeInHierarchy == true)
        {
            SceneManager.LoadScene(12);
        }
    }
}
