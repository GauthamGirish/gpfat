using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLight : MonoBehaviour
{
    private Light myLight;
    
    
    void Start ()
    {
        myLight = GetComponent<Light>();
    }
    
    
    void Update ()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
        //myLight.intensity = Mathf.Lerp(GetComponent<Light>().intensity, 8f, 0.5f * Time.deltaTime);
    }
}
