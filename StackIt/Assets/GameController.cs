using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //bring down the Quader
            QuaderController.quaderFallen = true;
        }
    }
}
