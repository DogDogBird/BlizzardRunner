using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager_Diablo : MonoBehaviour {
	public int randomScore;
	public int randomAge;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{

			randomScore = Random.Range(-50,50);
			randomAge = Random.Range (-5,5);

			ScoreManager.GetInstance().AddScore (randomScore);
			AgeManager.Getinstance().AddAge (randomAge);

			gameObject.SetActive (false);
		}
	}
}
