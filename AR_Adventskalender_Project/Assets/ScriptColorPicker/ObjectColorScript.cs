using UnityEngine;

namespace ScriptColorPicker
{
    public class ObjectColorScript : MonoBehaviour
    {
        // Start is called before the first frame update
        public Material activeMaterial;


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
}
