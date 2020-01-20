using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingBorderMesh : MonoBehaviour
{
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.fixedTime%.5<.2)
        {
            rend.enabled=false;
        }
        else
        {
            rend.enabled=true;
        }
        
    }

}
