using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject currentQuader;
    public GameObject lastQuader;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentQuader.GetComponent<Rigidbody>().useGravity = true;
           QuaderController.speedStoped = false;
        }
        if (Input.GetMouseButtonDown(1))
        {
         //   newQuader();
        }

    }
}
