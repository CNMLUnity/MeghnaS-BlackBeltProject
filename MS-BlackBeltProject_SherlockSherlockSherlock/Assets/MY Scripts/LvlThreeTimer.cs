using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LvlThreeTimer : MonoBehaviour
{
    //public GameObject Time;
    public int number;
    public TMP_Text eeeee;
    public TMP_Text timeheading;
    public float startTime;
    public float elapsedTime;
    public float timeLeft = 7.0f;
    // Start is called before the first frame update
    void Start()
    {
       
        eeeee.enabled = true;
        timeheading.enabled = true;
        startTime = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        number = 25;
        eeeee.text = number.ToString();
        elapsedTime = Time.time - startTime;
        timeLeft = 25 - elapsedTime;
        number --;
        print(elapsedTime);
        eeeee.text = timeLeft.ToString("0.00");

        if(elapsedTime >= 25)
        {
            SceneManager.LoadScene(9);
        }
    
    }
}
