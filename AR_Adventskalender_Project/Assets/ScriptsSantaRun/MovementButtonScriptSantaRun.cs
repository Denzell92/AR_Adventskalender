using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementButtonScriptSantaRun : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lane1;
    public GameObject lane2;
    public GameObject lane3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MovePlayerToLane()
    {
        GameObject player = GameObject.Find("Player");
        var playerScript = player.GetComponent<PlayerScriptSantaRun>();

        if (gameObject.name == "ButtonLeftSantaRun")
        {
            if (playerScript.playerLane == lane1)
            {
                playerScript.playerLane = lane3;
            }
            else if (playerScript.playerLane == lane2)
            {
                playerScript.playerLane = lane1;
            }
        }
        else if (gameObject.name == "ButtonRightSantaRun")
        {
            if (playerScript.playerLane == lane1)
            {
                playerScript.playerLane = lane2;
            }
            else if (playerScript.playerLane == lane3)
            {
                playerScript.playerLane = lane1;
            }
        }
    }
}
