﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {

    private void Start()
    {
        AudioSource starMusic = GetComponent<AudioSource>();
        starMusic.Play();
        
    }
    public void PVP()
    {
        SceneManager.LoadScene("Main");
    }
    public void PVE()
    {
        SceneManager.LoadScene("PVE");
    }

    public void Quit()
    {
       //Debug.Log("Quit!");
        Application.Quit();
    }
}
