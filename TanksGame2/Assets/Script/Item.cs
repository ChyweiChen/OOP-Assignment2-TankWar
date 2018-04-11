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
        GameObject.Destroy(this.gameObject);

        if (collider.tag == "tank")  //when shell touch tank
        {
            if (ItemType == 0)
                collider.SendMessage("Add_Health");
            if (ItemType == 1)
            collider.SendMessage("Add_Damage");
            if (ItemType == 2)
                collider.SendMessage("Add_Speed");

        }
    }
}
