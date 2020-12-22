using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject gameStartUI;
    public TextMeshProUGUI scoreText;
    public bool gameOver;

    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        ShowScore();
        if (gameOver && Input.GetTouch(0).phase == TouchPhase.Began && gameStartUI.activeSelf == true)
        {
            QuitGame();
        }
    }
    public void StartGame()
    {
        gameStartUI.SetActive(false);
        SpawnManager.startGame = true;
        gameOver = false;

    }
    public void EndGame()
    {
        GameController.gcInstance.scoreText.enabled = false;
        gameOver = true;
        PauseGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;

        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            gameStartUI.SetActive(true);
            gameOver = true;

        }
    }

    public void ShowScore()
    {
        scoreText.text = "LAST SCORE: " + GameController.counter;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is Exit");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
