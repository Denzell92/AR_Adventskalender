using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SnowmanSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject marker;
    public GameObject enemy;
    float timer = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var trackedScript = marker.GetComponent<TrackableBehaviour>();
        var status = trackedScript.CurrentStatus;

        if (status == TrackableBehaviour.Status.TRACKED)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                GameObject newEnemy = (GameObject)Instantiate(enemy);
                newEnemy.transform.parent = marker.transform;
                var enemyScript = newEnemy.GetComponent<EnemyScript>();
                enemyScript.target = GameObject.Find("Target");
                newEnemy.transform.position = new Vector3(Random.Range(transform.position.x + 4, transform.position.x - 4), transform.position.y, transform.position.z);
                timer = 5f;
            }
        }
    }
}
