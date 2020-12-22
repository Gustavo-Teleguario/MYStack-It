using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController gcInstance;
    public static int counter;
    public TextMeshProUGUI scoreText;
    float limit = 0.515f;

    private void Awake()
    {
        gcInstance = this;
    }

    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began && !GameManager.instance.gameOver)
        {
            QuaderController.quaderFallen = true;
            GameManager.instance.StartGame();
            scoreText.enabled = true; 
        }

    }

    public void SetCountText()
    {
        counter++;
        QuaderController.speed += 0.05f;
        scoreText.text = "Score: " + counter.ToString();
    }

    public void CheckUnderLimit()
    {
        if (SpawnManager.spawnInstance.oldPrefab.transform.position.y < limit)
        {
            GameManager.instance.EndGame();
        }
    }
}
