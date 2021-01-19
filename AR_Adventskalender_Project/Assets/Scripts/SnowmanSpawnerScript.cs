using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SnowmanSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject marker;
    public GameObject snowMan;
    public GameObject snowWoman;
    float timer = 1f;
    List<GameObject> enemyList;
    void Start()
    {
        enemyList = new List<GameObject>();
        enemyList.Add(snowMan);
        enemyList.Add(snowWoman);
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
                GameObject newEnemy = (GameObject)Instantiate(enemyList[(int)Random.Range(0.0f, 1.99f)]);
                newEnemy.transform.parent = marker.transform;
                var enemyScript = newEnemy.GetComponent<EnemyScript>();
                enemyScript.target = GameObject.Find("Target");
                newEnemy.transform.position = new Vector3(Random.Range(transform.position.x + 8, transform.position.x - 8), transform.position.y, transform.position.z);
                timer = 2f;
            }
        }
    }
}
