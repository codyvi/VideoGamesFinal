﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void VolverAJugar()
    {
        SceneManager.LoadScene(1);
    }

    public void Salir()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
   
}