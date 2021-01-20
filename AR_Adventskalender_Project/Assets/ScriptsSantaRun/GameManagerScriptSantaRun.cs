using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScriptSantaRun : MonoBehaviour
{

    public GameObject retryButton;
    public float timer;
    public float nextSpeedRaise = 0;
    public Text survivedTimeText;
    void Start()
    {
        retryButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        nextSpeedRaise += Time.deltaTime;
        survivedTimeText.text = "Survived Time: " + (int)timer;
        if (nextSpeedRaise > 10)
        {
            nextSpeedRaise = 0;
            MovingGroundsScript.speed += 3;
        }
    }

    public void CallGameOverScreen()
    {
        Time.timeScale = 0;
        retryButton.SetActive(true);
    }
}
