using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager_Wow : MonoBehaviour {
	public int RandomAge;
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

			RandomAge = Random.Range (-5,5);

			AgeManager.Getinstance().AddAge (RandomAge);

			gameObject.SetActive (false);
		}
	}
}
