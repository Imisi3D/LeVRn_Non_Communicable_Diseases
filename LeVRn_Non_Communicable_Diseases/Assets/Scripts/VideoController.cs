using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer video;

    private bool toggle;

    public GameObject textToShow;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseVideo()
    {
        video.Pause();
        textToShow.SetActive(true);
    }

    public void PlayVideo()
    {
        video.Play();
        textToShow.SetActive(false);
        
    }
}
