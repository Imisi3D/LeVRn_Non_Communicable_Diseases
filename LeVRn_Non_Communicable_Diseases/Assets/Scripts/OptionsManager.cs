using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;


public class OptionsManager : MonoBehaviour , ISelectHandler, IPointerClickHandler, IDeselectHandler
{
    public GameObject[] rightAnswers;
    public GameObject[] wrongAnswers;

    public GameObject submitButton;

    public int objectSelected;
    
    private static int optionsSelected;
    Color initialColour;

    public TextMeshProUGUI counterText;
    public TextMeshProUGUI warningtext;
    public bool selected;
    
    public HashSet<OptionsManager> allQuizOptions = new HashSet<OptionsManager>();
    public HashSet<OptionsManager> selectedQuizOptions = new HashSet<OptionsManager>();


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

  public void OnPointerClick(PointerEventData eventData)
    {
        /*if (objectSelected % 2 == 1)
        {
            OnSelect(eventData);
        }
        else if (objectSelected % 2 == 0)
        {
            OnDeselect(eventData);
        }*/
    }
    
    public void OnSelect(BaseEventData eventData)
    {
        //selectedQuizOptions.Add(this);
        eventData.selectedObject.GetComponent<Image>().color = Color.green;
        //gameObject.GetComponent<Image>().color = Color.green;
        objectSelected++;
        selected = true;
        print("Object selected = " + objectSelected);
        //if (objectSelected % 2 == 0)
        //{
        //OnDeselect(eventData);
        //}
        //else if (objectSelected % 2 == 1)
        // {
        // objectSelected++;
        // print("Object selected = " + objectSelected);
        //}
    }

    public void OnDeselect(BaseEventData eventData)
    {
        //selectedQuizOptions.Remove(this);
        if (objectSelected % 2 == 1)
        {
            objectSelected--;
            print("Object selected = " + objectSelected);

            eventData.selectedObject.GetComponent<Image>().color = initialColour;
        }
        
    }
}
