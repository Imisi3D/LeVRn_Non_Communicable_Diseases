using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DisabledScript : MonoBehaviour
{
    private float finalScore;

    [SerializeField]
    private TextMeshProUGUI totalScoreText;

    public Animator anim;

    [SerializeField]
    private string sceneToLoad;

    [SerializeField]
    private GameObject acknowledgmentObject;

    
    
    public void TotalScore(Button overallAnswer)
    {
        anim.gameObject.SetActive(true);
        anim.Play("Loading Answer");
        
        overallAnswer.interactable = false;

        StartCoroutine(DisplayAnswer()); 
        
        StartCoroutine(DisplayAcknowledgementObject(10)); 
        
        Invoke("DelayedRestart", 14);
    }

    IEnumerator DisplayAnswer()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(2, 5));
        
        anim.gameObject.SetActive(false);
        
        int scoreCalculation = ResultManager.newScore + QuizManager.score;
        finalScore = Mathf.CeilToInt(((float) scoreCalculation / 34) * 100);
        totalScoreText.text = $"{finalScore}%";
    }
    
    void DelayedRestart()
    {
        SceneManager.LoadSceneAsync(sceneToLoad);
    }
    
    IEnumerator DisplayAcknowledgementObject(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        
       
        acknowledgmentObject.SetActive(true);
        Debug.Log($"acknowledgment displayed");
    }
}
