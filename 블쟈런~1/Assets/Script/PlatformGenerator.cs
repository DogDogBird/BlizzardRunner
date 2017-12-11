using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {
    public GameObject thePlatform;
    public Transform generationPoint;
    public PlayerController thePlayer;
    //public float distanceBetween;

    private float platformWidth;
    private bool IsFirst = true;

   // public float distanceBetweenMin;
   // public float distanceBetweenMax;

    public GameObject[] thePlatforms;
    private int platformSelector;
    //private float[] platformWidths;

    //private float minHeight;
    // public Transform MaxHeightPoint;
    // private float maxHeight;
    // public float maxHeightChange;
    // private float heightChange;
    // public ObjectPooler theObjectPool;
    // Use this for initialization
    void Start () {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
        thePlayer = FindObjectOfType<PlayerController>();
       // platformWidths = new float[thePlatforms.Length];

        //for (int i = 0; i < thePlatforms.Length; i++)
        // {
        //    platformWidths[i] = thePlatforms[i].GetComponent<BoxCollider2D>().size.x;
        // }
        // minHeight = transform.position.y;
        // maxHeight = MaxHeightPoint.position.y;
    }
	
	// Update is called once per frame
	void Update () {
        if (thePlayer.IsDead || IsFirst)
        {
           // distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);
            //platformSelector = Random.Range(0, thePlatforms.Length);

           // heightChange = transform.position.y+Random.Range(maxHeightChange,-maxHeightChange);

           // transform.position = new Vector3(transform.position.x + platformWidths[platformSelector] + distanceBetween, heightChange, transform.position.z);

          

            Instantiate(/*thePlatform*/thePlatforms[platformSelector], transform.position, transform.rotation);
            /* GameObject newPlatform = theObjectPool.GetPooledObject();

             newPlatform.transform.position = transform.position;
             newPlatform.transform.rotation = transform.rotation;
             newPlatform.SetActive(true); */
            IsFirst = false;
        }
	}
}
