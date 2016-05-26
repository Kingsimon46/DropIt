using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text highScoreText;

    private float scoreCount;
    private float highScoreCount;

    public float pointsPerDrop;
	// Use this for initialization
	void Start () {

        highScoreCount = PlayerPrefs.GetFloat("HighScore");

	}
	
	// Update is called once per frame
	void Update () {

        scoreText.text = "Score: " + scoreCount;

        if(scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", highScoreCount);
        }

        highScoreText.text = "High Score: " + highScoreCount;

	}
    
    public void AddScore()
    {
        scoreCount += pointsPerDrop;

    }
}
