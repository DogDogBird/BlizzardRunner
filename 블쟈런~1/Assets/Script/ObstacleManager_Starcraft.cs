using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager_Starcraft : MonoBehaviour {

	public PlayerController thePlayer;
	public GameManager theGameManager;
	// Use this for initialization
	void Start () {
		thePlayer = GetComponent<PlayerController> ();
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			theGameManager.RestartGame ();//게임 터는 효과
		}
	}
}
