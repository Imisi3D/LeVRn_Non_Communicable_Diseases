using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashingBorder : MonoBehaviour
{
   // private Renderer rend;
    private Image img;
    private Color startColour;
    private Color endColour;

    // Start is called before the first frame update
    void Start()
    {
       // rend = GetComponent<SpriteRenderer>();
       
        img = GetComponent<Image>();
        startColour = img.color;
        endColour = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.fixedTime%.5<.2)
        {
            img.color=startColour;
            //img.color = Color.yellow;
            //img.enabled = true;
        }
        else
        {
            //img.enabled = false;
            img.color=endColour;
        }
        
    }

}
