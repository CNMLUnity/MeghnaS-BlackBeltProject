using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameObject Time;
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        number = 7;
    }

    // Update is called once per frame
    void Update()
    {
        number --;
        number.ToString();
        print("SHerlockio");
    }
    //public void Increment()
    //{
      
    //}
}
