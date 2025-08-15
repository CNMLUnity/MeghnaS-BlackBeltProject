using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetStuff : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public GameObject[] targets;
    private int targetIndex = 0;
    public GameObject Circle;
    public  Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        targets[targetIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction*100, Color.green);
        if(Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.transform.gameObject);
            if(Input.GetMouseButtonDown(0) && hit.transform.CompareTag("Target"))
            {
                Debug.Log(hit.transform.gameObject);
                print ("hit!");
                targets[targetIndex].SetActive(false);
                targetIndex++;
                Debug.Log("next target"); 
                if(targetIndex >= targets.Length && timer.timeLeft >= 0) 
                {
                    SceneManager.LoadScene(7);
                }
                targets[targetIndex].SetActive(true);
            }

        }
            if(timer.BoutonClicked && timer.timeLeft < 0)
            {
                SceneManager.LoadScene(3);
                Invoke("ReloadScene", 5);
            }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(6);
    }
}
