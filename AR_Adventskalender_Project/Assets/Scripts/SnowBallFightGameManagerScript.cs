using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnowBallFightGameManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreBoard;
    public int points = 0;

    void Start()
    {
        
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
}
