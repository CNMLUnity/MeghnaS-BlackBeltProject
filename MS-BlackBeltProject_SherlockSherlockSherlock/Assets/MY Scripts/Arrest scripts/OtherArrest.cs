using UnityEngine;
using UnityEngine.SceneManagement;

public class OtherArrest : MonoBehaviour
{
    public Arrest arrest;
    public bool hasHandcuffs;
    public int currentScene = 6;
    // Start is called before the first frame update
    void Start()
    {
        hasHandcuffs = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(arrest.handcuffs.activeInHierarchy == true)
        {
            hasHandcuffs = true;
            print(hasHandcuffs);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.tag);
        print(hasHandcuffs);    
        if(other.gameObject.tag == "Player" && hasHandcuffs == true)
        {
            print(currentScene + 1);
            print(hasHandcuffs);
            SceneManager.LoadScene(currentScene + 1);
        }
    }
}
