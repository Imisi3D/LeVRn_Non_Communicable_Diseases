using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollControl : MonoBehaviour
{
    public Scrollbar scrollBar;

    private void Update()
    {
        if(Input.GetAxis("Mouse Y") != 0)
        {
            scrollBar.value += ((Input.mousePosition.y - 720) / 720);
        }
    }


    /*public void MoveScroll()
    {
        if(Input.GetAxis("Mouse Y") != 0)
        {
            scrollBar.value += ((Input.mousePosition.y - 720) / 720);
        }
        
        /*Vector2 touchPad = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);

        if (touchPad.y >= 0f)
        {
            scrollBar.value += ((Input.mousePosition.y - 720) / 720);
        }
        else if (touchPad.y <= 0)
        {
            scrollBar.value -= ((Input.mousePosition.y - 720) / 720);
        }#1#

    }*/
    
    
}
