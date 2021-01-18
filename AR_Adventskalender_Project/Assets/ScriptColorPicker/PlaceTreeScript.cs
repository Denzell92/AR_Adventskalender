using UnityEngine;

namespace ScriptColorPicker
{
    public class PlaceTreeScript : MonoBehaviour
    {
        public GameObject tree;  
        public GameObject groundPlane;  

        public void MoveTree()
        {
            groundPlane.gameObject.SetActive(true);
            tree.transform.SetParent(groundPlane.transform, false);
        }
    }
}
