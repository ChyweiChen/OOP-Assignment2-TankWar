using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame_PVP : MonoBehaviour {
    public Text gameover;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject player1 = GameObject.Find("Tank1");
        if (null == player1)
        {

            gameover.text = "Player2 is Winner " + "\n Please press 'R' to restart" + "\n Please press 'Esc' to back Menu";
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Main");
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("Menu");
            }
        }
        GameObject player2 = GameObject.Find("Tank2");
        if (null == player2)
        {

            gameover.text = "Player1 is Winner " + "\n Please press 'R' to restart" + "\n Please press 'Esc' to back Menu";
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Main");
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("Menu");
            }
        }

    }
}
