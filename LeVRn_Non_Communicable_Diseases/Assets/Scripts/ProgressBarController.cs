using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBarController : MonoBehaviour
{
    
    public LineRenderer lRender;

    public GameObject progressBar;
    
   
    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        transform.rotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTrackedRemote);

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (OVRInput.Get(OVRInput.Touch.PrimaryTouchpad))
            {
                progressBar.SetActive(false);
            }
        }

        else
        {
            if (OVRInput.Get(OVRInput.Touch.PrimaryTouchpad))
            {
                progressBar.SetActive(true);
            }
        }
    }

}
