using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SignHolder : MonoBehaviour
{
    public GameObject signPost;
    public GameObject textCanvas;
    public double signDisableTime;

    public double signDisplayTime;
    public VideoPlayer videoP;



    
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(DisableSign());
    }

    // Update is called once per frame
    void Update()
    {
        // displayTime -= Time.deltaTime;
       if (videoP.time < signDisplayTime)
       {
           signPost.SetActive(false);
       }
       else if (videoP.time >= signDisplayTime)
       {
           signPost.SetActive(true);
       }

       if (videoP.time >= signDisableTime)
       {
           signPost.SetActive(false);
           textCanvas.SetActive(false);
          // videoP.Play();
       }

    }

    //Disables the sign and ensures the video is playing if the sign
    /*IEnumerator DisableSign()
    {
        yield return new WaitForSeconds(signDisableTime);
        signPost.SetActive(false);
        videoP.Play();
    }*/
}
