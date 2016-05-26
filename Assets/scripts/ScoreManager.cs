using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text highScoreText;

    private float scoreCount;
    public float highScoreCount;

    public float pointsPerDrop;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        scoreText.text = "Score: " + scoreCount;

        if(scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;

        }


        highScoreText.text = "High Score: " + highScoreCount;

	}
    
    public void AddScore()
    {
        scoreCount =+ pointsPerDrop;

    }
}
