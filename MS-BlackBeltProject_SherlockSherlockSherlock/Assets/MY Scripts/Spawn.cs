using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Rendering;

public class Spawn : MonoBehaviour
{
    public TMP_Text Timer;
    public TMP_Text TimeText;
    public float number;
    public GameObject FirstGuard;
    public GameObject SecondGuard;
    public GameObject TimeKeeper;
    private float TimeStarted;
    public bool started = false;
    // Start is called before the first frame update
    void Start()
    {
        FirstGuard.SetActive (false);
        SecondGuard.SetActive (false);
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
            if (Time.time - TimeStarted >= 16)
            {
                FirstGuard.SetActive (true);
                SecondGuard.SetActive (true);
                //Invoke ("Stop", 1000);
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

