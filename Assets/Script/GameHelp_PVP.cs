using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHelp_PVP : MonoBehaviour {
    public Text help;
    // Use this for initialization
    void Start () {
        GameObject player1 = GameObject.Find("Tank1");
        if (null != player1)
        {
            help.text = "Player1 is Red Tank, Player 2 is Yellow Tank " + "\n 'WASD' to control Player1 move 'Space' for shot" + "\n '↑←↓→' to control Player2 move 'L' for shot";
            Invoke("killText", 5);
        }
    }
    void killText()
    {
        //GameObject.Destroy(this.gameObject);
        help.text = "";
    }
	
	// Update is called once per frame
	void Update () {

    }
}
