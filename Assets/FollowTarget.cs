using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {
    public Transform player1position;
    public Transform player2position;

    private Vector3 offset;

    private Camera camera;
	// Use this for initialization
	void Start () {
        offset = transform.position - (player1position.position + player2position.position) / 2;
        camera = this.GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (player1position == null || player2position == null)
        {
            return;
        }
        transform.position = offset + (player1position.position + player2position.position) / 2;
        float distance = Vector3.Distance(player1position.position, player2position.position);
        float size = distance * 1.00f;
        camera.orthographicSize = size;
    }
}
