using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl910Deactivate : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Background;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Canvas.SetActive(true);
        Background.SetActive(true);
        Player.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ByeByeCanvas()
    {
        //print ("hello");
        Canvas.SetActive(false);
        Background.SetActive(false);
        Player.SetActive(true);
    }
}


