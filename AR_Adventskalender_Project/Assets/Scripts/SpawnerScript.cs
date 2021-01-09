using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer = 5;
    public GameObject snowMan;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            GameObject newSnowman = (GameObject)Instantiate(snowMan);
            newSnowman.transform.position = new Vector3(Random.Range(transform.position.x + 10, transform.position.x -10), 0, 0);
            timer = 5;
        }
    }
}
