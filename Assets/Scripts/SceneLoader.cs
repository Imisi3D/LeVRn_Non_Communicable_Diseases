using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneLoader : MonoBehaviour
{
    public string nextSceneName;
    
    
    
    public void LoadScene()
    {
        SceneManager.LoadSceneAsync(nextSceneName, LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    /*public void PointerClickHandler( BaseEventData data )
    {
        PointerEventData pointerEventData = data as PointerEventData;
        GameObject pressed = pointerEventData.pointerPress;
 
        //Left click
        if (pointerEventData.button == PointerEventData.InputButton.Left ) {
            if( pointerEventData.clickCount == 1 )
            {
                LoadScene();
            }
            /*else if( pointerEventData.clickCount == 2 )
            {
                OnLeftDoubleClick( pressed );
            }
        }
        //Right click
        else if (pointerEventData.button == PointerEventData.InputButton.Right)
        {
            if (pointerEventData.clickCount == 1)
            {
                LoadScene();
            }
        

        else if( pointerEventData.clickCount == 2 )
        {
            OnRightDoubleClick( pressed );
        }
    }
    //Middle click
    else if (pointerEventData.button == PointerEventData.InputButton.Middle ) {
        if( pointerEventData.clickCount == 1 )
        {
            OnMiddleSingleClick( pressed );
        }
        else if( pointerEventData.clickCount == 2 )
        {
            OnMiddleDoubleClick( pressed );
        }
    }
    }*/

}
