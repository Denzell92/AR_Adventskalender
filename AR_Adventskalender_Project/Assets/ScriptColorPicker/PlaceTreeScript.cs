using UnityEngine;
using UnityEngine.SceneManagement;

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

        public void Reset()
        {
            SceneManager.LoadScene("TreeDecorator");
        }
    }
}
