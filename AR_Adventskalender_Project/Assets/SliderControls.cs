using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

// TODO: Convert to swipe controls once th labyrinth tilting works
public class SliderControls : MonoBehaviour
{
    public Slider slider;
    public Slider slider2;

    void Update()
    {
        transform.rotation = new Quaternion(slider.value, 0.0f, slider2.value, 0.0f);
        Debug.Log(transform.rotation);
    }
}
