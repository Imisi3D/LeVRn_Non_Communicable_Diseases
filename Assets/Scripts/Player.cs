using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 joyStick;
    public float speed;
    public GameObject centerEye;
    public GameObject ParentObject;

    
    // Start is called before the first frame update
    void Start()
    {
       // transform.Rotate(0, 90, 0);
    }

    // Update is called once per frame
    void Update()
    {
      //  joyStick = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
      
     transform.eulerAngles = new Vector3(0, centerEye.transform.localEulerAngles.y, 0);
     transform.Translate(Vector3.forward * speed * joyStick.y * Time.deltaTime); 
     transform.Translate(Vector3.right * speed * joyStick.x * Time.deltaTime);
        
     ParentObject.transform.position = Vector3.Lerp(ParentObject.transform.position, transform.position, 10f * Time.deltaTime);
    }

}
