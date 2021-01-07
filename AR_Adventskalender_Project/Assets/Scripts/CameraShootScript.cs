using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShootScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int bulletSpeed = 50;
    public GameObject bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            /*
            GameObject bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            bullet.transform.position = new Vector3(0, 0, -5);
            bullet.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
            bullet.AddComponent<Rigidbody>();
            */

            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            GameObject newBullet = (GameObject)Instantiate(bullet, mouseRay.origin, Quaternion.identity);
            Rigidbody rb = newBullet.GetComponent<Rigidbody>();


            rb.velocity = mouseRay.direction * bulletSpeed;
        }
    }
}
