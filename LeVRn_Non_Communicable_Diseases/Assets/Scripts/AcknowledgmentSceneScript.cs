using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcknowledgmentSceneScript : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(10);

        SceneManager.LoadSceneAsync(sceneToLoad);
    }
}
