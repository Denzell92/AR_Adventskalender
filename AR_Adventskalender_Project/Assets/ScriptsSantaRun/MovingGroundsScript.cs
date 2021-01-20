using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGroundsScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ground;
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject marker;
    public GameObject lane1;
    public GameObject lane2;
    public GameObject lane3;
    public GameObject gameManager;
    public static float speed = 1;

    bool obstaclesPlaced = false;
    bool newGroundSpawned = false;
    List<GameObject> obstacles;
    List<GameObject> lanes;

    void Start()
    {
        lane1 = GameObject.Find("Lane1");
        lane2 = GameObject.Find("Lane2");
        lane3 = GameObject.Find("Lane3");

        lanes = new List<GameObject>();
        lanes.Add(lane1);
        lanes.Add(lane2);
        lanes.Add(lane3);

        obstacles = new List<GameObject>();
        obstacles.Add(obstacle1);
        obstacles.Add(obstacle2);
        obstacles.Add(obstacle3);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        if (transform.position.z <= -5 && !newGroundSpawned)
        {
            marker = GameObject.Find("ImageTarget");
            newGroundSpawned = true;
            GameObject newGround = (GameObject)Instantiate(ground);
            newGround.transform.parent = marker.transform;
            //newGround.transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
            //bringt der Quatsch ueberhaupt was??????
            newGround.transform.rotation = new Quaternion(0, 0, 0, 0);

            newGround.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 10);

            if (!obstaclesPlaced)
            {
                obstaclesPlaced = true;
                GameObject newObstacle = (GameObject)Instantiate(obstacles[(int)Random.Range(0.0f,2.99f)]);
                newObstacle.transform.parent = transform;

                if (newObstacle.gameObject.name.Contains("gignerbread"))
                {
                    //newObstacle.transform.position = new Vector3(transform.position.x, 1.5f, transform.position.z + 10);
                    //lanes[(int)Random.Range(0.0f, 2.99f)]
                    newObstacle.transform.position = new Vector3(lanes[(int)Random.Range(0.0f, 2.99f)].transform.position.x, 1.5f, transform.position.z + 10);

                }
                else
                {
                    //newObstacle.transform.position = new Vector3(transform.position.x,3, transform.position.z + 10);
                    newObstacle.transform.position = new Vector3(lanes[(int)Random.Range(0.0f, 2.99f)].transform.position.x, 3, transform.position.z + 10);
                }
            }

        }
        else if (transform.position.z <= -20)
        {
            Destroy(gameObject);
        }
    }
}
