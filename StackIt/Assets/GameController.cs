using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static int counter;


    private void Start()
    {
        counter = 0;
    }
    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //bring down the Quader
            QuaderController.quaderFallen = true;
        }
    }
}
