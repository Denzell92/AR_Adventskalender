using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonColorScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Material colorMaterial;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void respond()
    {
        List<ObjectColorScript> scriptList = new List<ObjectColorScript>();
        scriptList.AddRange(FindObjectsOfType(typeof(ObjectColorScript)) as ObjectColorScript[]);

        foreach (ObjectColorScript c in scriptList)
        {
            c.activeMaterial = colorMaterial;
        }
    }
}
