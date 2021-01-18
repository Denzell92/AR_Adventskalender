using System;
using UnityEngine;

namespace ScriptColorPicker
{
    public class PlaceTree : MonoBehaviour
    {
        public GameObject tree;
        public GameObject groundPlane;

        public void Start()
        {
            groundPlane.gameObject.SetActive(false);
        }

        protected void OnGUI()
        {
            if (GUILayout.Button("Place Tree", GUILayout.Height(200), GUILayout.Width(200)))
            {
                groundPlane.gameObject.SetActive(true);
                tree.transform.SetParent(groundPlane.transform, false);
            }
        }
    }
}
