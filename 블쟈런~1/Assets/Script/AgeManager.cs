using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgeManager : MonoBehaviour {
    public Text ageText;
    public float ageCnt;

    public float startAge;

    public bool ageIncreasing;

	public GameManager theGameManager;
    private static AgeManager instance;

    // Use this for initialization

    public static AgeManager Getinstance()
    {
        if (instance == null)
        {
            instance = FindObjectOfType<AgeManager>();

            if (instance == null)
            {
                GameObject container = new GameObject("AgeManager");
                instance = container.AddComponent<AgeManager>();
            }
        }
        return instance;
    }

	void Start () {
        ageCnt = startAge;
        if (PlayerPrefs.HasKey("startAge"))
        {
            startAge = PlayerPrefs.GetInt("startAge");
        }
        ageIncreasing = true;

    }
	
	// Update is called once per frame
	void Update () {
        if (ageIncreasing)
        {
            ageCnt += 1 * Time.deltaTime;
            ageText.text = "Age: " + Mathf.Round(ageCnt);
        }
        if (ageCnt >= 40)
        {
            ageText.text = "게임 끝!";//게임 끝 화면 출력
			theGameManager.RestartGame();//게임 끝
            ageIncreasing = true;
        } 
        
	}

	public void AddAge(float age)
	{
		ageCnt += age;
	}

	public float getAge()
	{
		return ageCnt;
	}


}
