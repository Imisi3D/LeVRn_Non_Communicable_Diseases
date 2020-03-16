using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AcknowledgmentSceneScript : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;

    [SerializeField]
    private GameObject acknowledgmentObject;

    [SerializeField]
    private GameObject yourScore;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DisplayAcknowledgmentObject(5));

        Invoke("DelayedRestart", 8);
    }

    IEnumerator DisplayAcknowledgmentObject(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        
        yourScore.SetActive(false);
       
        acknowledgmentObject.SetActive(true);
    }

    void DelayedRestart()
    {
        SceneManager.LoadSceneAsync(sceneToLoad);
    }
}
