using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrenderLampara : MonoBehaviour
{

    public bool on = true;
    public Light my_light;
    public int batteryLife;

    void Start()
    {
        on = true;
        batteryLife = 100;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {

            if (on == true)
            {
                my_light.enabled = false;
                on = false;
                
            }
            else
            {
                my_light.enabled = true;
                on = true;
            }
        }

        while(on == true)
        {
            batteryLife -= 5;
        }

        if(batteryLife == 0)
        {
            my_light.enabled = false;
        }

    }
}