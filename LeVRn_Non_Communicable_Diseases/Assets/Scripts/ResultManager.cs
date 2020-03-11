using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;



//[assembly:System.Runtime.CompilerServices.InternalsVisibleTo("Assembly-CSharp-Editor")]

public class ResultManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] questions;

   [SerializeField]
    private GameObject youAreCorrect;

    [SerializeField]
    private GameObject correctAnswer;
    

    private int currentOption;

    public static int newScore;

    [SerializeField]
    private TextMeshProUGUI finalScoreText;
    
    public void CorrectAnswer()
    {
        youAreCorrect.SetActive(true);
        
        newScore++;
        //FinalResultCalculator.generatedScore++;
        //FinalResultCalculator.finalScore = Mathf.CeilToInt(((float)FinalResultCalculator.generatedScore / 34) * 100);
        //finalScoreText.text = FinalResultCalculator.finalScore+"%".ToString();
        Debug.Log("Newscore = " + newScore);
        
        for (int i = 0; i < questions.Length; i++)
        {
            questions[i].SetActive(false);
        }

        StartCoroutine(DisableBoard());
    }

    public void OnNextQuestionClicked()
    {
        correctAnswer.SetActive(false);
        currentOption++;
        for (int i = 0; i < questions.Length; i++)
        {
            questions[i].SetActive(false);
            questions[currentOption].SetActive(true);
        }
    }

    public void WrongAnswer(Button thisButton)
    {
        //correctAnswer.SetActive(true);
        thisButton.GetComponent<Image>().color = new Color(1f, 0.2941f, 0.3372f);
        StartCoroutine(DisableBoard());
    }

    IEnumerator DisableBoard()
    {
        yield return new WaitForSeconds(5);
        youAreCorrect.SetActive(false);
        
        correctAnswer.SetActive(true);
        
        for (int i = 0; i < questions.Length; i++)
        {
            questions[i].SetActive(false);
        }
    }

    public void GoToTheNextVideo(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
