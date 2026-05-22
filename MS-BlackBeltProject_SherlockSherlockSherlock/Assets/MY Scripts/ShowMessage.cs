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
    void Show(Collider other)
    {
        if(other.gameObject.name == "Murderess" && Input.GetKeyDown(KeyCode.P))
        {
            MurderBlock.SetActive(true);
            MurderText.SetActive(true);
        }
        if(other.gameObject.name == "Forgetful" && Input.GetKeyDown(KeyCode.P))
        {
            ForgetfulBlock.SetActive(true);
            ForgetfulText.SetActive(true);
        }
        if(other.gameObject.name == "Spiteful" && Input.GetKeyDown(KeyCode.P))
        {
            SpitefulBlock.SetActive(true);
            SpitefulText.SetActive(true);
        }
        if(other.gameObject.name == "Bobby" && Input.GetKeyDown(KeyCode.P))
        {
             BobbyBlock.SetActive(true);
            BobbyText.SetActive(true);
        }
    }
    void OnTriggerEnter (Collider other)
    {
        Show(other);
        print(other.gameObject.name);
        if(other.gameObject.name == "Murderess" && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(currentScene + 1);
        }
    }
}
