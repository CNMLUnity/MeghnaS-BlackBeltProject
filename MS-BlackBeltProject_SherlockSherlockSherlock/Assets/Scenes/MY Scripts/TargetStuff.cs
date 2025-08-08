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
            if(Input.GetMouseButtonDown(0))
            {
                print ("hit!");
                targets[targetIndex].SetActive(false);
                targetIndex++;
                if(targetIndex >= targets.Length) 
                {
                    SceneManager.LoadScene(7);
                }
                targets[targetIndex].SetActive(true);
            }
        }
    }
}
