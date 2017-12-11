using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    //public Transform platformGenerator;
    //private Vector3 platformStartPoint;

    public PlayerController thePlayer;
    //private Vector3 playerStartPoint;
    public DeathMenu theDeathMenu;

    // Use this for initialization
    void Start () {
        // platformStartPoint = platformGenerator.position;
        // playerStartPoint = thePlayer.transform.position;
        thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void RestartGame()
    {
        thePlayer.gameObject.SetActive(false);
        ScoreManager.GetInstance().scoreIncreasing = false;
        AgeManager.Getinstance().ageIncreasing = false;
        theDeathMenu.gameObject.SetActive(true);
        //StartCoroutine("RestartGameCo");
    }

    public void Reset()
    {
        theDeathMenu.gameObject.SetActive(false);
        //platformGenerator.position = platformStartPoint;

        //thePlayer.gameObject.SetActive(true);
        SceneManager.LoadScene("GaeGaebi Runner");
        
    }

   /* public IEnumerator RestartGameCo()
    {
        thePlayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        thePlayer.transform.position = thePlayer.GetStartPoint();
        //platformGenerator.position = platformStartPoint;

        //thePlayer.gameObject.SetActive(true);
        SceneManager.LoadScene("GaeGaebi Runner");
    }*/

}
