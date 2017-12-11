using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour {
    private Rigidbody2D myRigidbody;
    public float ArrowSpeed;

    
	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        myRigidbody.velocity = new Vector2(-ArrowSpeed, myRigidbody.velocity.y);
	}
}
