using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] questions;

   [SerializeField]
    private GameObject youAreCorrect;

    [SerializeField]
    private GameObject correctAnswer;

    private int currentOption;


    public void CorrectAnswer()
    {
        youAreCorrect.SetActive(true);
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
    
    
}
