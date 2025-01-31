﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scr_DatosCuriosos : MonoBehaviour {

    [Tooltip("Datos curiosos: se hara random entre este arreglo. Formato Text Mesh Pro")]
    public string[] datosCuriosos;
    public string[] curiousFacts;
    public TextMeshProUGUI txtDisplay;
    [Header("Carga de escena")]
    public Scr_SceneManager sceneManager;
    public float segundosEnPantalla = 5;
    public string escenaACargar = "GameScene";

    int randomIndex = 0;

    private void Start()
    {
        txtDisplay.text = GetRandomText();
        sceneManager.LoadSceneAfterSeconds(escenaACargar, segundosEnPantalla);
    }

    /// <summary>
    /// Toma un dato curioso aleatorio
    /// </summary>
    /// <returns>regresa el string del dato curioso</returns>
    string GetRandomText()
    {
        string result;
        if(Scr_Lang.isEnglish)
        {
            randomIndex = Random.Range(0, curiousFacts.Length);
            result = curiousFacts[randomIndex];
        }
        else
        {
            randomIndex = Random.Range(0, datosCuriosos.Length);
            result = datosCuriosos[randomIndex];
        }
        return result; 
    }

    
}
