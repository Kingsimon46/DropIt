﻿using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {

    public static LevelController instance;

    private int points = 0;
    private int cycleCount = 1;

    // Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Called after good color-check
    public static void StartNewCycle()
    {
        Debug.Log("Load New Level initated");
        // Call class for adding points
        // Call class for increasing cycleCount and difficulty
        // Call ObjectPooler to remove current drop and setup platform for new cicle
        // Call ObjectSpawner to spawn new drop
        
    }

    void increaseDifficulty()
    {

    }
}
