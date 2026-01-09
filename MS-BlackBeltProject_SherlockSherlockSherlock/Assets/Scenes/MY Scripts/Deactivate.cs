using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject AlsoCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Canvas.SetActive(true);
        AlsoCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ByeByeCanvas()
    {
        Canvas.SetActive(false);
        AlsoCanvas.SetActive(true);
    }
}
