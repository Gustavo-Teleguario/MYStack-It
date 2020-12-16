using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began && GameController.counter > 2)
        {
            moveSpeed = 5f;
            this.transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            Debug.Log("Touch it");
        }


    }
}
