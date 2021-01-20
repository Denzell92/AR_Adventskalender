using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScriptSantaRun : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    public GameObject playerLane;
    void Start()
    {
        playerLane = GameObject.Find("Lane1");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerLane.transform.position, speed * Time.deltaTime);
    }
}
