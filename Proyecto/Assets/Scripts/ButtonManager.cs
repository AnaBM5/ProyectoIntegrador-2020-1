﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public TextMeshProUGUI xd;
    public void OnClicRegister()
    {
        SceneManager.LoadScene("Welcome-Login", LoadSceneMode.Single);
    }
    public void OnClickLogin()
    {
        SceneManager.LoadScene("login", LoadSceneMode.Single);
    }
    
    public void OnClickWelcome()
    {
        SceneManager.LoadScene("Welcome", LoadSceneMode.Single);
    }
    public void onclickOnMouseUpGame()
    {
        
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
    public void onclickOnMouseUpLeaderboard()
    {
        
        SceneManager.LoadScene("LeaderBoard", LoadSceneMode.Single);
    }
    public void onclickOnMouseUpMenu()
    {
        
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void onclickReglas()
    {
        xd.text = "solo disfruta";
    }
    
    public void onclickSignOut()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }
    
 
}
