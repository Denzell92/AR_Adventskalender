﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtonSantaRunScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReloadSantaRun()
    {
        MovingGroundsScript.speed = 1;
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
