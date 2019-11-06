using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choque : MonoBehaviour
{

    public Text Txt;

    public static int llavesRecogidas;

    // Start is called before the first frame update
    void Start()
    {
        Txt.text = "Llaves: ";
        llavesRecogidas = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Txt.text = "Llaves: " + llavesRecogidas;
    }
    
    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "llave1")
        {
            llavesRecogidas++;
            Destroy(col.gameObject);
        }

        if(col.gameObject.name == "llave2") 
        {
            llavesRecogidas++;
            Destroy(col.gameObject);
        }
        if(col.gameObject.name == "llave3")
        {
            llavesRecogidas++;
            Destroy(col.gameObject);
        }
    }
}
