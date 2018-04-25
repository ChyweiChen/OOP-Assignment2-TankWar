using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restart : MonoBehaviour {
	public Text gameover;

	void Start()
	{
			
	}
	void Update()
	{
		
		GameObject player = GameObject.Find("player");
		//TankHealth TH = (TankHealth)player.GetComponent(typeof(TankHealth));
//Debug.Log(TH.hp);
GameObject go = GameObject.Find("ScoreControler");
		Score other = go.GetComponent<Score>();
		
		
		if(null == player)
		{
	
	      gameover.text = "GameOver your score is: " + other.score + "\n Please press 'R' to restart";
		  if( Input.GetKeyDown(KeyCode.R) )
		  {
			  SceneManager.LoadScene("PVE");
		  }
		  
		  
		}
		
	}
	
 
}
