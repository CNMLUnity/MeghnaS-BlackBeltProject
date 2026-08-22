using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl910Deactivate : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Background;
    public GameObject Player;
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        Canvas.SetActive(true);
        Background.SetActive(true);
        Player.SetActive(false);
        Enemy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ByeByeCanvas()
    {
        Canvas.SetActive(false);
        Background.SetActive(false);
        Player.SetActive(true);
        Enemy.SetActive(true);
    }
}


