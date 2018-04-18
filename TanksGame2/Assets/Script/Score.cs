using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
public Text scoreText;
private int score;
	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore();
	}
	
	void UpdateScore()
	{
		scoreText.text = "Score: " + score;
	}
	
	public void addScore(int value)
	{
		score += value;
		UpdateScore();
	}
}
