using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    private float speed;
    public GameObject objectToMove;

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        //Output the name of the GameObject that is being clicked
        Debug.Log(name + "Game Object Click in Progress");
        var catcherScript = objectToMove.GetComponent<CatcherScript>();

        catcherScript.speed = speed;
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        Debug.Log(name + "Game Object Click lost");
        var catcherScript = objectToMove.GetComponent<CatcherScript>();

        catcherScript.speed = 0;
    }
    void Start()
    {
        if (gameObject.name == "ButtonLeft")
        {
        Debug.Log("Hello Darling");
            speed = -10f;
        }
        else if (gameObject.name == "ButtonRight")
        {
            speed = 10f;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*public void moveObject()
    {
        var catcherScript = GameObject.Find("Catcher").GetComponent<CatcherScript>();

        catcherScript.speed = speed;
    }*/
}
