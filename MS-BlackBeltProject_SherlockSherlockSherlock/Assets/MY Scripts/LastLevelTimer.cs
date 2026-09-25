using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class LastLevelTimer : MonoBehaviour
{
    public Animator SherlockAnim;
    public Animator MomoAnim;
    public TMP_Text Timer;
    public TMP_Text TimeText;
    public float number;
    public GameObject TimeKeeper;
    private float TimeStarted;
    public bool started = false;
    // Start is called before the first frame update
    void Start()
    {
        TimeKeeper.SetActive(true);
        TimeStarted = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(TimeKeeper.activeInHierarchy == false)
        {
            started = false;
        }
        if (started)
        {
            if (Time.time - TimeStarted > (15))
            {
                print("HAIL SHERLOCK!!!");
                SherlockAnim.SetTrigger("Health");
                MomoAnim.SetTrigger("Die");
                SceneManager.LoadScene(12);
            } else
            {
                number = Time.time - TimeStarted;
                TimeText.text = number.ToString("0.00");
            }
        }
    }
    public void ToggleStarted()
    {
        if (!started)
        {
            started = true;
        }
        else
        {
            started = false;
        }
    }
}

