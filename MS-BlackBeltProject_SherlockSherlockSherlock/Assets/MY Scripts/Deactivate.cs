using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject AlsoCanvas;
    public GameObject SceneCube;
    // Start is called before the first frame update
    void Start()
    {
        Canvas.SetActive(true);
        SceneCube.SetActive(true);
        AlsoCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ByeByeCanvas()
    {
        Canvas.SetActive(false);
        SceneCube.SetActive(false);
        AlsoCanvas.SetActive(true);
    }
}
