using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        moveSpeed = 15f;

        //if (Input.GetTouch(0).phase == TouchPhase.Began && GameController.counter > 3)
        if (!SpawnManager.createQuader && GameController.counter > 3)
        {
            this.transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }

    }
}
