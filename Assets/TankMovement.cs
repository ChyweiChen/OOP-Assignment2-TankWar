using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

    public float speed = 5;
    public float angularSpeed = 30;
    public int number = 1; //judge a player by different number 
    private new Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
        rigidbody = this.GetComponent<Rigidbody>();
	}
	
	

    void FixedUpdate()
    {
        float v = Input.GetAxis("Verticalplayer"+number);
        rigidbody.velocity = transform.forward * v * speed;

        float h = Input.GetAxis("player" + number + "Horizontal");
        rigidbody.angularVelocity = transform.up * h * angularSpeed;
    }
}
