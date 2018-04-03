﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITank : MonoBehaviour {
    public GameObject player;
	public float moveSpeed;
	public float attackRange;
	public float shootCoolDown;
	
	private float timer;
	
	private TankAttack ta;
	// Use this for initialization
	void Start () { 
		ta = GetComponent<TankAttack>();
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		timer += Time.fixedDeltaTime;
		float dist = Vector3.Distance(player.transform.position, transform.position);
		if(dist > attackRange)
		{
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		}
		transform.LookAt(player.transform.position);
		
		if(timer > shootCoolDown)
		{
			ta.Shoot();
			timer = 0f;
		}
		
	}
}
