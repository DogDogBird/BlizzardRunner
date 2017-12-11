using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager_Heos : MonoBehaviour
{
    
    public PlayerController player;
  
    // Use this for initialization
    void Start ()
    {
        player = FindObjectOfType<PlayerController>();
    }
	
	// Update is called once per frame
	void Update ()
    {
	}

    //닿으면 캐릭터 맨 처음 위치로 이동
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.transform.position = player.GetStartPoint();
            gameObject.SetActive(false);
        }
    }
}
