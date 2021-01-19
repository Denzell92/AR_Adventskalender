using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnowBallFightGameManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreBoard;
    public int points = 0;
    public Button retryButton;

    void Start()
    {
        retryButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RaisePoints()
    {
        points += 100;
        scoreBoard.text = "Points: " + points;
    }

    public void callMenuGameOver()
    {
        Time.timeScale = 0;
        retryButton.gameObject.SetActive(true);
    }
}
