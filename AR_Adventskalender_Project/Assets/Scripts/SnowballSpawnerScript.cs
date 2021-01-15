using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SnowballSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public GameObject shootingPos;
    public GameObject marker;
    public float speed = 50;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var trackable = marker.GetComponent<TrackableBehaviour>();
        var status = trackable.CurrentStatus;
        if (status == TrackableBehaviour.Status.TRACKED)
        {
            transform.position = shootingPos.transform.position;

            if (Input.GetMouseButtonDown(0))
            {
                Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                GameObject newBullet = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);
                var bulletScript = newBullet.GetComponent<BulletScript>();
                bulletScript.referencePoint = marker;
                newBullet.transform.parent = marker.transform;
                Rigidbody rb = newBullet.GetComponent<Rigidbody>();


                rb.velocity = mouseRay.direction * speed;
            }
        }
    }
}
