using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class EndVideoTextController : MonoBehaviour
{
    public GameObject whatIsCancer, typesOfCancer, causesOfCancer, preventionOfCancer;

    public VideoPlayer endVideoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (endVideoPlayer.time >= 118.3)
        {
            endVideoPlayer.Pause();
            whatIsCancer.SetActive(true);
            typesOfCancer.SetActive(true);
            causesOfCancer.SetActive(true);
            preventionOfCancer.SetActive(true);
        }
    }
}
