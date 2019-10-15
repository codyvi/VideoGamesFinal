using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prender : MonoBehaviour
{
    public Light my_light; 

    void Start()
    {
        my_light = GetComponent<Light>();
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
           
            if(my_light.enabled)
            {
                my_light.enabled = false;
            }
            else
            {
                my_light.enabled = true;
            }
        }
        
    }
}
