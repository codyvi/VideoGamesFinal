using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrenderLampara : MonoBehaviour
{
    public Text txt;

    public bool on = true;
    public Light my_light;
    public float maxEnergy;
    public float currentEnergy;
    private int batteryLife;
    public static int BateriasAMostrar;

    void Start()
    {
        on = true;
        maxEnergy = 25;
        currentEnergy = maxEnergy;
        txt.text = "Baterias: ";
    }


    // Update is called once per frame
    void Update()
    {
        txt.text = "Baterias: " + BateriasAMostrar;
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


        if(on == true)
        {
            
            if(currentEnergy <= 0)
            {
                my_light.enabled = false;
            }

            if(currentEnergy > 0)
            {
                currentEnergy -= 0.5f * Time.deltaTime;
                BateriasAMostrar = (int) currentEnergy;
            }
        }

        else if(on == false)
        {
            if (currentEnergy < 25)
            {
                currentEnergy += 0.5f * Time.deltaTime;
                BateriasAMostrar = (int) currentEnergy;
            }
        }

    }
}