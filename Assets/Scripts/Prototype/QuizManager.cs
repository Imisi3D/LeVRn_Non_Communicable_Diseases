using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour, ISelectHandler, IPointerClickHandler, IDeselectHandler
{
    public GameObject[] rightAnswers;
    public GameObject[] wrongAnswers;

    public GameObject submitButton;

    public int objectSelected;
    
    private static int optionsSelected;
    Color initialColour;
    
    public HashSet<QuizManager> allQuizOptions = new HashSet<QuizManager>();
    public HashSet<QuizManager> selectedQuizOptions = new HashSet<QuizManager>();


    private void Awake()
    {
        allQuizOptions.Add(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        initialColour = gameObject.GetComponent<Image>().color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckAnswers()
    {
        
    }

    public void SelectedOptions()
    {
        /*objectSelected++;
        gameObject.GetComponent<Image>().color = Color.green;
        optionsSelected++;
        print("Options selected = " + optionsSelected);
        if (objectSelected % 2 == 0)
        {
            gameObject.GetComponent<Image>().color = initialColour;
            optionsSelected--;
            print("Updated options = " + optionsSelected);
        }*/
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnSelect(eventData);
    }
    
    public void OnSelect(BaseEventData eventData)
    {
        //selectedQuizOptions.Add(this);
        gameObject.GetComponent<Image>().color = Color.green;
        if (objectSelected % 2 == 0)
        {
            //OnDeselect(eventData);
        }
        else if (objectSelected % 2 == 1)
        {
            objectSelected++;
            print("Options selected = " + objectSelected);
        }
    }

    public void OnDeselect(BaseEventData eventData)
    {
        //selectedQuizOptions.Remove(this);
        objectSelected--;
        print("Options selected = " + objectSelected);

        gameObject.GetComponent<Image>().color = initialColour;
    }
}
