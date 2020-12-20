using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController gcInstance;
    public static int counter;
    public TextMeshProUGUI scoreText;


    private void Awake()
    {
        gcInstance = this;
    }
    private void Start()
    {

    }
    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            QuaderController.quaderFallen = true;
            GameManager.instance.StartGame();
            scoreText.enabled = true;
        }
    }

    public void SetCountText()
    {
        counter++;
        scoreText.text = "Score: "+counter.ToString();
    }
}
