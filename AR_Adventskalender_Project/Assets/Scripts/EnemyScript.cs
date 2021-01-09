using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    float speed = 1;
    public GameObject target;
    int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("DeathZone");
    }

    // Update is called once per frame
    void Update()
    {
        //movement funktioniert, eventuell ausgleichen des Wackelns
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z), step);

        checkHealth();

    }

    private void OnCollisionEnter(Collision collision)
    {
        health -= 25;
    }

    private void checkHealth()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
