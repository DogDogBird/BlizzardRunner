using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text highScoreText;

    public float scoreCount;
    public float highScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;

	private static ScoreManager instance;

	public static ScoreManager GetInstance()
	{
		if (instance == null) {
			instance = FindObjectOfType<ScoreManager> ();

			if (instance == null) {
				GameObject container = new GameObject ("ScoreManager");
				instance = container.AddComponent<ScoreManager> ();
			}
		}
		return instance;
	}

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
        scoreIncreasing = true;

    }
	
	// Update is called once per frame
	void Update () {
        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }

        if (scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", highScoreCount);
        }

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);        
	}

    public void AddScore(int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }
    public void PointToZero()
    {
        scoreCount = 0;
    }

    public float GetScore()
    {
        return scoreCount;
    }
    public void SetScore(float _score)
    {
        scoreCount = _score;
    }
}
