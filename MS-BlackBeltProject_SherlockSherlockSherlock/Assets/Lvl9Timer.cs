using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine.SceneManagement;

public class Lvl9Timer : MonoBehaviour
{
    public TMP_Text Timer;
    public TMP_Text TimeText;
    public float number;
    public bool started = false;
    public int currentScene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (started)
        {
            if (Time.time >= 30)
            {
                SceneManager.LoadScene (currentScene + 1);
            } else
            {
                number = Time.time;
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


