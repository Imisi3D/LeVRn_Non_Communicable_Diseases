using System;
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

    
    public void CorrectAnswer(Button correctOption)
    {
        correctOption.GetComponent<Image>().color = new Color(0.1254902f, 0.9607843f, 0.7098039f, 1f);
        
        Invoke("DisplayCorrectOptionBadge", 2);
        
        newScore++;
        Debug.Log("Newscore = " + newScore);
        
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
        thisButton.GetComponent<Image>().color = new Color(1f, 0.2941f, 0.3372f, 1f);
        StartCoroutine(DisableBoard());
    }

    IEnumerator DisableBoard()
    {
        yield return new WaitForSeconds(2);
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

    void DisplayCorrectOptionBadge()
    {
        youAreCorrect.SetActive(true);
        
        for (int i = 0; i < questions.Length; i++)
        {
            questions[i].SetActive(false);
        }
    }
}
