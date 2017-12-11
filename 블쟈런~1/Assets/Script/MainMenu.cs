using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public string playGameLevel;
    // Use this for initialization
    public void PlayGame()
    {
        Application.LoadLevel(playGameLevel);
    }
    public void QuitGame()
    {
        Application.Quit(); 
    }
}
