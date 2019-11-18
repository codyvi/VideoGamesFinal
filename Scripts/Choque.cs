using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Choque : MonoBehaviour
{

    public Text Txt;

    public static int llavesRecogidas;
    public bool perdiste;

    // Start is called before the first frame update
    void Start()
    {
        Txt.text = "Llaves: ";
        llavesRecogidas = 0;
        perdiste = false;
    }

    // Update is called once per frame
    void Update()
    {
        Txt.text = "Llaves: " + llavesRecogidas;

        if(perdiste)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(1);
        }

    }
    
    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "llave1" || col.gameObject.name == "llave2" || col.gameObject.name == "llave3")
        {
            llavesRecogidas++;
            Destroy(col.gameObject);
        }

        //Dejar asi temporalmente, cambiar cuando esten los niveles 
        if( (col.gameObject.name == "Puerta1" || col.gameObject.name == "Puerta2" || col.gameObject.name == "Puerta3" ) && llavesRecogidas == 3)
        {
            perdiste = true;
        }
    }
}
