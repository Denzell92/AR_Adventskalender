using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatcherScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 offset;
    public float speed = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(speed * Time.deltaTime, 0, 0);
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
