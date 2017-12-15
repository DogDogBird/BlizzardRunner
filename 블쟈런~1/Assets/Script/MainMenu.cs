using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string playGameLevel;
	public string character;
	public string upgrade;
	// Use this for initialization


	public void Charactershop()
	{
		SceneManager.LoadScene(character);
	}

	public void Upgradeshop()
	{
		SceneManager.LoadScene(upgrade);
	}

    public void PlayGame()
    {
		SceneManager.LoadScene(playGameLevel);

    }

    public void QuitGame()
    {
        Application.Quit(); 
    }
}
