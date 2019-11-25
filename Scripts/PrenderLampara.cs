using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PrenderLampara : MonoBehaviour
{
    public Text txt;

    public bool on = true;
    public bool perdiste = false;
    public Light my_light;
    public float maxEnergy;
    public float currentEnergy;
    private int batteryLife;
    public static int BateriasAMostrar;
    public AudioSource audioData;

    void Start()
    {
        on = true;
        maxEnergy = 25;
        currentEnergy = maxEnergy;
        txt.text = "Bateria: ";
    }


    // Update is called once per frame
    void Update()
    {
        txt.text = "Bateria: " + BateriasAMostrar;
        //Controlador para prender y apagar la lampara 

        if(perdiste)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(2);
        }


        if (Input.GetKeyDown(KeyCode.F))
        {

            if (on == true)
            {
                my_light.enabled = false;
                on = false;
                audioData.Play();
                
            }
            else
            {
                my_light.enabled = true;
                on = true;
                audioData.Play();
            }
        }

        //If para bajar la bateria de la lampara
        if(on == true)
        {
            //Si se llega a acabar la bateria, pierdes llevandote a una scene de perder 
            if(currentEnergy <= 0)
            {
                my_light.enabled = false;
                perdiste = true;
            }
            //Bajar la bateria de la lampara 
            if(currentEnergy > 0)
            {
                currentEnergy -= 0.5f * Time.deltaTime;
                my_light.intensity -= 0.005f;
                BateriasAMostrar = (int) currentEnergy;
            }
        }
        //If para subir la bateria de la lampara
        else if(on == false)
        {
            if (currentEnergy < 25)
            {
                currentEnergy += 0.25f * Time.deltaTime;
                my_light.intensity += .0005f;
                BateriasAMostrar = (int) currentEnergy;
            }

            if(currentEnergy == 25)
            {
                 my_light.intensity = 15f;
            }
        }

    }

}