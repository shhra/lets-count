﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCriterion : MonoBehaviour {

    // Use this for initialization
    private static int BallCount;
    private static int score;
    public static bool isRunning;
    int missed;
	void Start () {
        BallCount = 0;
        score = 0;
        isRunning = true;

    }
	
	// Update is called once per frame
	void Update () {
        IsRunning();
        score = InputManager.score;
        BallCount = DestroyBall.ballDestroyed;
        missed = BallCount - score;
        if (missed > 3)
        {
            Debug.Log("GAME OVER! GG NOOB!");
            Application.LoadLevel("tryAgain");
            isRunning = false; 
        }
        
    }
    public void IsRunning()
    {
        isRunning = true;
    }
   
}
