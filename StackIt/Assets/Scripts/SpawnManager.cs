using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager spawnInstance;
    public GameObject[] quaderPrefabs;
    public Camera myCamera;
    public GameObject currentPrefab;
    public GameObject oldPrefab;
    public static bool createQuader = false;
    public static bool startGame = false;
    public Transform other;

    private void Awake()
    {
        spawnInstance = this;
    }
    // Update is called once per frame
    int quederIndex;
    void Update()
    {
        if (startGame)
        {
            if (!createQuader)
            {
                createNewQuader();
                createQuader = true;
            }
        }
        GameController.gcInstance.CheckUnderLimit();
    }

    void createNewQuader()
    {
        bool distance = false;
        Vector3 spawnPosition;
        oldPrefab = currentPrefab;
        if (GameController.counter < 4 && !distance)
        {
            spawnPosition = new Vector3(0, 2.5f, -2f);
        }
        else
        {
            spawnPosition = new Vector3(0, oldPrefab.transform.position.y * 1.5f, -2f);
            distance = true;
        }

        quederIndex = 0;
        currentPrefab = Instantiate(quaderPrefabs[quederIndex], spawnPosition, quaderPrefabs[quederIndex].transform.rotation);
        QuaderController.speedStoped = true;
    }

}
