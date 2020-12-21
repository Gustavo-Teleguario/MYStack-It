using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Update()
    {
        Vector3 pos = new Vector3(5, SpawnManager.spawnInstance.oldPrefab.transform.position.y, 0);
        if (!SpawnManager.createQuader && GameController.counter > 3)
        {
            this.transform.position = pos;
        }

    }
}
