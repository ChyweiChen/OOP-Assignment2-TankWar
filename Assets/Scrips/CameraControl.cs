using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
[HideInInapector]
public Transform[] m_Targets;
public float m_ScreenEdgeBuffer = 4f;
public float m_DampTime = 0.2f;

private Camera m_Camera;
private float m_ZoomSpeed;
private Vectors m_MoveVelocity;
private vectors m_DesiredPosition

	// Use this for initialization
	void Awake()
	{
		m_Camera = GetComponentInChildren<Camera>();
	}
	void FixedUpdate()
	{
		Move();
		Zoom();
	}
	void Move()
	{
		Vector3 averagePos = new Vector3();
		int numTargets = 0;
		for(int i =0; i<m_Targets.Length; i++)
		{
			if(!m_Targets[i].gameObject.activeSelf)
				continue;
			averagePos += m_Targets[i].position;
			numTargets++;
		}
		if(numTargets > 0)
			averagePos /=numTargets
		
		averagePos.y = transform.position.y;
		m_DesiredPosition = averagePos;
		
		transform.position = Vector3.SmoothDamp(transform.position, m_DesiredPosition, ref m_MoveVelocity, m_DampTime);
	}
	void Zoom()
	{
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
