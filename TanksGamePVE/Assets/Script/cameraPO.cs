using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPO : MonoBehaviour {
    public Transform player1position;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = player1position.position - transform.position;

	}
	
	// Update is called once per frame
	void Update () {
        if (player1position == null)
        {
            return;
        }
        transform.position = player1position.position - offset;
       
    }
}
