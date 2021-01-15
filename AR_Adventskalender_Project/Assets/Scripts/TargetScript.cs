using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.name == "Enemy")
        {
            Debug.Log("Kommt da Was?");
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tell me something");
        if (other.transform.gameObject.name == "Enemy")
        {
            Debug.Log("Kommt da Was?");
            SceneManager.LoadScene("SampleScene");
        }
    }
}
