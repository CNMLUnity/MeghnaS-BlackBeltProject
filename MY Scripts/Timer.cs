using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //public GameObject Time;
    public int number;
    public TMP_Text eeeee;
    public TMP_Text timeheading;
    public bool BoutonClicked = false;
    public float startTime;
    public float elapsedTime;
    public float timeLeft = 7.0f;
    // Start is called before the first frame update
    void Start()
    {
       eeeee.enabled = false;
       timeheading.enabled = false;
    }
    
    public void BootonClicked()
    {
        startTime = Time.time;
        BoutonClicked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(BoutonClicked == true)
        {
            timeheading.enabled = true;
            eeeee.enabled = true;
            number = 5;
            eeeee.text = number.ToString();
            elapsedTime = Time.time - startTime;
            timeLeft = 5 - elapsedTime;
            number --;
            //print("SHerlockio");
            eeeee.text = timeLeft.ToString("0.00");
        }
    }
}
