using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    VideoPlayer videoController;
    void Start()
    {
        videoController = GetComponent<VideoPlayer>();
        videoController.Pause();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (videoController.isPlaying)
        {
            videoController.Pause();
        } else if (!videoController.isPlaying)
        {
            videoController.Play();
        }
    }
}
