using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PresentSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject redPresent;
    public GameObject bluePresent;
    public GameObject greenPresent;
    public GameObject violetPresent;
    List<GameObject> presentList;
    public GameObject marker;
    public float timer = 0;
    void Start()
    {
        presentList = new List<GameObject>();
        presentList.Add(redPresent);
        presentList.Add(bluePresent);
        presentList.Add(greenPresent);
        presentList.Add(violetPresent);
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
                GameObject newPresent = (GameObject)Instantiate(presentList[(int)Random.Range(0, 4)]);
                newPresent.transform.parent = marker.transform;

                //newPresent.transform.position = new Vector3(Random.Range(15, -15), transform.position.y, transform.position.z);
                newPresent.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

                timer = 5f;
            }
        }
    }
}
