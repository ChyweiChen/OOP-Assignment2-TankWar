using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyForTime : MonoBehaviour {
    public float Time ;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, Time); // destroy after Time is gone
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
