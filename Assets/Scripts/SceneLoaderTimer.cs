using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;


public class SceneLoaderTimer : MonoBehaviour
{
    public VideoPlayer vidPlayer;
    public float timeScene;

    public string theNextScene;

    public GameObject textToDisplay;
    public int buttonPressed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SceneTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SceneTimer()
    {
        yield return new WaitForSeconds(timeScene);
        vidPlayer.loopPointReached += VideoEndTime;
    }

    private void VideoEndTime(VideoPlayer vplayer)
    {
        //SceneManager.LoadScene(theNextScene);
        SceneManager.LoadSceneAsync(theNextScene, LoadSceneMode.Single);
    }

    private void PauseVideo()
    {
        vidPlayer.Pause();
        textToDisplay.SetActive(true);
    }

    void PlayVideo()
    {
        vidPlayer.Play();
        textToDisplay.SetActive(false);
    }

    public void TogglePlayPause()
    {
        buttonPressed++;
        if (buttonPressed % 2 == 1)
        {
            PauseVideo();
        }
        else if (buttonPressed % 2 == 0)
        {
            PlayVideo();
        }
    }
}
