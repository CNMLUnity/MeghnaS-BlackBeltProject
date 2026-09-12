using UnityEngine;

public class SwitchTrack : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip initial;
    public AudioClip final;
    private int trackNumber = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!audioSource.isPlaying)
        {
            if(trackNumber == 0)
            {
                audioSource.clip = final;
                trackNumber = 1;
            }
            else
            {
                audioSource.clip = initial;
                trackNumber = 0;
            }
            audioSource.Play();
        }
    }
}
