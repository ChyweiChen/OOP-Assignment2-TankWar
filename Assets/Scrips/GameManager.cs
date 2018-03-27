using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
  public GameObject m_TankPrefab;
  public TankManager[] m_Tanks;
  public GameObject[] m_SpawnPoint;	
	// Use this for initialization
	void Start () {
		/*
		for(int i = 0; i < m_Tanks.Length; i++)
		{
	m_Tanks[i] = Instantiate(m_TankPrefab, m_SpawnPoint[i].transform.position,m_SpawnPoint[i].transform.rotation) as TankManager;
		}
		*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
