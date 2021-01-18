using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class PresentCatcherManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timerText;
    public GameObject marker;
    public float timer = 5;
    public int points = 0;
    public bool gameOver = false; 
    void Start()
    {
        marker = GameObject.Find("ImageTarget");
    }

    // Update is called once per frame
    void Update()
    {
        var trackedScript = marker.GetComponent<TrackableBehaviour>();
        var status = trackedScript.CurrentStatus;

        if (status == TrackableBehaviour.Status.TRACKED)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                timerText.text = "Seconds Left " + (int)timer;
            }

            if (timer <= 0 && !gameOver)
            {
                gameOver = true;
                int numSmallPresents = GameObject.FindGameObjectsWithTag("SmallPresent").Length;
                int numBigPresents = GameObject.FindGameObjectsWithTag("BigPresent").Length;

                points += (numSmallPresents * 100);
                points += (numBigPresents * 500);

                timerText.text = "You got: " + points + " points";
            }
        }
    }
}
