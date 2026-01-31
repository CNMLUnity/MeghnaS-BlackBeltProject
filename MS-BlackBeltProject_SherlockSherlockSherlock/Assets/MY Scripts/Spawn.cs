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
    // Start is called before the first frame update
    void Start()
    {
        FirstGuard.SetActive (false);
        SecondGuard.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        number = Time.time;
        TimeText.text = number.ToString("0.00");
        if (Time.time >= 30)
        {
            FirstGuard.SetActive (true);
            SecondGuard.SetActive (true);
            Invoke ("Stop", 1000);
        }
    }
    void Stop()
    {
        this.enabled = false;
    }
}

