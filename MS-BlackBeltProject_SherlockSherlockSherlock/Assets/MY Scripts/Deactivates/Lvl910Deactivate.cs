using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl910Deactivate : MonoBehaviour
{
    public GameObject TimeKeeper;
    public LastLevelTimer LastLevelTimer;
    public GameObject Canvas;
    public GameObject Background;
    public GameObject Player;
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        LastLevelTimer.started = false;
        Canvas.SetActive(true);
        Background.SetActive(true);
        Player.SetActive(false);
        Enemy.SetActive(false);
        TimeKeeper.SetActive(false);
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
        TimeKeeper.SetActive(true);
        LastLevelTimer.started = true;
    }
}


