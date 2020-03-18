using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPausePlayMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject subMenuObject;

    [SerializeField]
    private VideoPlayer videoPlayer;

    private bool ispaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Back) || Input.GetMouseButtonDown(1))
        {
            if (!ispaused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    void Pause()
    {
        ispaused = true;
        videoPlayer.Pause();
        Time.timeScale = 0f;
        subMenuObject.SetActive(true);
    }

    public void Resume()
    {
        ispaused = false;
        videoPlayer.Play();
        Time.timeScale = 1f;
        subMenuObject.SetActive(false);
    }

    public void Home(string sceneName)
    {
        subMenuObject.SetActive(false);
        SceneManager.LoadSceneAsync(sceneName);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
