using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentScript : MonoBehaviour
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
        if (transform.position.y < referencePoint.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
