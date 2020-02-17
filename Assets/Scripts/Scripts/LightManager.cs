using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    
    public Light lt;
    void Start() {
        float timeUntilInvoked = 1.0f;//Seconds to pass before invoke
        Invoke("TriggerFunction", timeUntilInvoked);//Invoke certain function after 1.0f seconds. 3 initially
    }
 
    void TriggerFunction() {
        StartCoroutine("FadeIn");//Start a coroutine to run independent from the update function
    }
 
    IEnumerator FadeIn() {
        float duration = 10.0f;//time you want it to run, 5 initially.
        float interval = 0.1f;//interval time between iterations of while loop. .1 intially.
        lt.intensity = 0.0f;
        while (duration >= 0.0f) {
            lt.intensity += 0.01f; //.02f initially.
            
            duration -= interval;
            yield return new WaitForSeconds(interval);//the coroutine will wait for 0.1 secs
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
