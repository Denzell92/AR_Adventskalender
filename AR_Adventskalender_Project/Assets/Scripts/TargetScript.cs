using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.transform.gameObject.name == "Enemy")
        {
            SceneManager.LoadScene("SampleScene");
        }*/
        if (collision.transform.gameObject.name.Contains("snow_"))
        {
            var gameManagerScript = gameManager.GetComponent<SnowBallFightGameManagerScript>();
            gameManagerScript.callMenuGameOver();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.name.Contains("snow_"))
        {
            var gameManagerScript = gameManager.GetComponent<SnowBallFightGameManagerScript>();
            gameManagerScript.callMenuGameOver();
        }
    }
}
