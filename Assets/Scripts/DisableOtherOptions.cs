using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableOtherOptions : MonoBehaviour
{
    [SerializeField]
    private Button optionsToDisable1;
    
    [SerializeField]
    private Button optionsToDisable2;
    
    [SerializeField]
    private Button[] optionsToDisable;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OtherOptions()
    {
        for (int i = 0; i < optionsToDisable.Length; i++)
        {
            optionsToDisable[i].enabled = false;
        }
        //optionsToDisable1.enabled = false;
        //optionsToDisable2.enabled = false;
    }
}
