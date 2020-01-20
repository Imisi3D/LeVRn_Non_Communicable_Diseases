using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ToggleSign : MonoBehaviour
{
    public GameObject signObject;
    public GameObject UIObject;
    public VideoPlayer video;

    private bool toggle;

    public float toggleTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ToggleSignPost());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ToggleSignPost()
    {
        yield return new WaitForSeconds(toggleTime);
        signObject.SetActive(false);
        UIObject.SetActive(false);
        video.Play();
    }
}
