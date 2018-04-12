using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    public int ItemType;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider collider)
    {

        if (collider.tag == "tank")  //when tank touch item
        {
			if (ItemType == 0) {
				collider.SendMessage ("Create");
				collider.SendMessage ("Add_Health");
			} else if (ItemType == 1) {
				collider.SendMessage ("Add_Damage");
				collider.SendMessage ("Create");
			} else if (ItemType == 2) {
				collider.SendMessage ("Add_Speed");
				collider.SendMessage ("Create");
			}
        }
		GameObject.Destroy(this.gameObject);
    }
}
