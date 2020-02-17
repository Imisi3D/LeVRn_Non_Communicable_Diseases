using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public GameObject go;
    public GameObject enableText;
    public GameObject scrollB;
    public GameObject empty;
    public GameObject activeAudio;
    public GameObject inactiveAudio;

    public GameObject objectHolder;

    public int buttonPressed;
    private int buttonActivationPressed;
    public GameObject goController;
    private LineRenderer lRender;
    
    private bool infoCanvasPressed;
    public float infoAudioisPlaying;
    public float totalAudioPlayingTime;
    
    // Start is called before the first frame update
    void Start()
    {
        empty = new GameObject();
        go = empty;

        infoAudioisPlaying = 0;
        lRender = GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
        {
            buttonActivationPressed++;
            if (buttonActivationPressed % 2 == 1)
            {
               goController.SetActive(false);
               lRender.enabled = false;
            }
            else if (buttonPressed % 2 == 0)
            {
                goController.SetActive(true);
                lRender.enabled = true;
            }
        }
        
        RaycastHit hit;
        transform.rotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTrackedRemote); 

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider != null)
            {
                
                if (go != hit.collider.gameObject)
                {
                    //The OnCollisionExit-like method is called here first
                    go.transform.SendMessage("Method to Call");
                    go = hit.transform.gameObject;
                    //the OnCollisionEnter-like method is called here.
                    go.SendMessage("Method to call");
                }
                if (enableText != hit.collider.gameObject)
                {
                    //The OnCollisionExit-like method is called here first
                    enableText.transform.SendMessage("Method to Call");
                    enableText = hit.transform.gameObject;
                    //the OnCollisionEnter-like method is called here.
                    enableText.SendMessage("Method to call");                
                }

                if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
                {
                    //The method holding actions to be executed when the trigger is pressed goes here
                    go.transform.SendMessage("LoadScene");
                }
                
                if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
                {
                    //The method holding actions to be executed when the trigger is pressed goes here
                    //Uisng gameObject.transform.SendMessage("methodName") to load a new scene.
                   // enableText.transform.SendMessage("PlayVideo");
                   buttonPressed++;
                   if (buttonPressed % 2 == 1)
                   {
                       enableText.SendMessage("PauseVideo");
                       //infoCanvasPressed = true;
                       //infoAudioisPlaying += Time.deltaTime;
                   }
                   else if (buttonPressed % 2 == 0)
                   {
                       enableText.SendMessage("PlayVideo");
                       //totalAudioPlayingTime = infoAudioisPlaying;
                   }
                }

                if (OVRInput.Get(OVRInput.Touch.PrimaryTouchpad))
                {
                    scrollB.SendMessage("MoveScroll");
                }

                /*if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
                {
                    anotherGo.transform.SendMessage("ManyScene");
                }*/
            }
        }
        //This else is relative to OnCollisionExit
        else
        {
            if (go != null)
            {
                go.transform.SendMessage("Method to call");
                go = empty;
            }

            if (enableText != null)
            {
                enableText.transform.SendMessage("Method to call");
                enableText = empty;
            }
        }

    }
}
