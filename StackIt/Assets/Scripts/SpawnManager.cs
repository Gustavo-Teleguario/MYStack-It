using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] quaderPrefabs;
    public Camera myCamera;
    private GameObject currentPrefab;
    public static bool createQuader = false;

    // Start is called before the first frame update
    void Start()
    {
       // quaderFallen = false;
       // createQuader = false;
    }

    // Update is called once per frame
    int quederIndex;
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.S))
        if (!createQuader)
        {
            createNewQuader();
            createQuader = true;
        }
    }

    void createNewQuader()
    {
        float cameraPosition = myCamera.transform.position.y - 2f;
        Vector3 spawnPosition;
       
        if(GameController.counter < 7)
        {
             spawnPosition = new Vector3(0, (cameraPosition * 2.5f), -2f);
        }
        else
        {
            spawnPosition = new Vector3(0, (cameraPosition * 3f), -2f);
        }

        quederIndex = 0;
        //Random.Range(0, quaderPrefabs.Length);
        currentPrefab = Instantiate(quaderPrefabs[quederIndex], spawnPosition, quaderPrefabs[quederIndex].transform.rotation);
        QuaderController.speedStoped = true;
    }
   
}
