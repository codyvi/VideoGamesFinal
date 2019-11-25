using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void Instrucciones()
    {
        SceneManager.LoadScene(1);
    }

    public void Creditos()
    {
        SceneManager.LoadScene(1);
    }

    public void Terminar()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
   
}