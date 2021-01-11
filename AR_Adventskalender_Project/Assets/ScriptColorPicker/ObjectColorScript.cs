using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Material activeMaterial;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (activeMaterial != null)
            {
                GetComponent<Renderer>().material = activeMaterial;
            }
        }
    }
}
