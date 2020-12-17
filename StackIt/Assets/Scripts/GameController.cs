using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public static int counter;
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        counter = 0;
        SetCountText();
    }
    void Update()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //bring down the Quader
            QuaderController.quaderFallen = true;
        }
        SetCountText();
        // Debug.Log("Counter " + counter);
    }

    public void SetCountText()
    {
        scoreText.text = "Score: " + counter.ToString();
    }
}
