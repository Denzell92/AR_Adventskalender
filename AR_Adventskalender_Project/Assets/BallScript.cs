using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject plane;

    public GameObject spawnPoint;

    protected void OnGUI()
    {
        if (GUILayout.Button("Spawn Ball", GUILayout.Height(500)))
        {
            if (transform.position.y < plane.transform.position.y - 10)
            {
                transform.position = spawnPoint.transform.position;
            }
        }
    }
}