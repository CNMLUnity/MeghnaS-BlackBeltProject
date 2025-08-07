using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetStuff : MonoBehaviour
{

    public bool is1Clicked;
    public bool is2Clicked;
    public bool is3Clicked;
    public bool is4Clicked;
    public bool is5Clicked;
    // Start is called before the first frame update
    void Start()
    {
        // Target1.SetActive(true);
        // Target2.SetActive(false);
        // Target3.SetActive(false);
        // Target4.SetActive(false);
        // Target5.SetActive(false);
    }

    void Click1() {
        is1Clicked = true;
    }
    void Click2() {
        is2Clicked = true;
    }
    void Click3() {
        is3Clicked = true;
    }
    void Click4() {
        is4Clicked = true;
    }
    void Click5() {
        is5Clicked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (is1Clicked && is2Clicked && is3Clicked && is4Clicked && is5Clicked) {
            SceneManager.LoadScene(7);
        }
        
        // if(Target1.isClicked == true)
        // {
        //     Target1.SetActive(false);
        //     Target2.SetActive(true);
        //     if(Target2.isClicked == true)
        //     {
        //         Target2.SetActive(false);
        //         Target3.SetActive(true);
        //         if(Target3.isClicked == true)
        //         {
        //             Target3.SetActive(false);
        //             Target4.SetActive(true);
        //             if(Target4.isClicked == true)
        //             {
        //                 Target4.SetActive(false);
        //                 Target5.SetActive(true);
        //                 if(Target5.isClicked == true)
        //                 {
        //                     SceneManager.LoadScene(7);
        //                 }
        //             }
        //         }
        //     }
        // }
    }
}
