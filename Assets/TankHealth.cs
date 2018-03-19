using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHealth : MonoBehaviour {

    public int hp = 100;
    public GameObject tanExplosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void TakeDamage()
    {
        if (hp <= 0) return;
        hp -= Random.Range(8,15);
        if (hp <= 0)
        {
            GameObject.Instantiate(tanExplosion, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);
        }

    }
}
