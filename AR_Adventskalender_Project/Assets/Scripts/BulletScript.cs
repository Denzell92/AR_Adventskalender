using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject referencePoint;
    void Start()
    {
        referencePoint = GameObject.Find("ImageTarget");
    }

    // Update is called once per frame
    void Update()
    {
        //ist okay aber noch fehlerbehaftet
        /*if (transform.position.y < -20)
        {
            Destroy(gameObject);
        }*/

        if (transform.position.y < referencePoint.transform.position.y)
        {
            Destroy(gameObject);
        }


    }
}
