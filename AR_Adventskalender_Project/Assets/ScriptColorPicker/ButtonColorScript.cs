using System.Collections.Generic;
using UnityEngine;

namespace ScriptColorPicker
{
    public class ButtonColorScript : MonoBehaviour
    {
        // Start is called before the first frame update

        public Material colorMaterial;
        
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
}