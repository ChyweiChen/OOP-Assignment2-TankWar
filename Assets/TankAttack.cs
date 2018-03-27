using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour {
    public GameObject shellPrefab;
    private Transform fireposition;
    public float shellSpeed = 10;
    public KeyCode firekey = KeyCode.Space;
	// Use this for initialization
	void Start () {
        fireposition = transform.Find("FirePosition");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(firekey))
        {
            GameObject go = GameObject.Instantiate(shellPrefab, fireposition.position, fireposition.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;

        }
	}
}
