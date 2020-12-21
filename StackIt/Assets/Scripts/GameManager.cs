using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject gameStartUI;

    private void Awake()
    {
        instance = this;
    }
    public void StartGame()
    {
        gameStartUI.SetActive(false);
        SpawnManager.startGame = true;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
}
