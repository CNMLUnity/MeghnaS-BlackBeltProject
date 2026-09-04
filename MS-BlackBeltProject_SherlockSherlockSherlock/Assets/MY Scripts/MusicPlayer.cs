using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public GameObject songPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(GameObject.FindGameObjectsWithTag("Background music").Length == 0)
        {
            GameObject musicPlayer = Instantiate(songPlayer, gameObject.transform);
            musicPlayer.transform.parent = null;
            DontDestroyOnLoad(musicPlayer);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
