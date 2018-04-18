using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHealth : MonoBehaviour {
    public int score1 = 1;
    public int hp = 100;
    public GameObject tanExplosion;
    public AudioClip tankExplosionAudio;
	//private Score S;
	
	// Use this for initialization
	void Start () {
		//S = GetComponent<Score>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {



	}

    void TakeDamage()
    {
		GameObject go = GameObject.Find("ScoreControler");
		Score other = (Score)go.GetComponent(typeof(Score));
        if (hp <= 0) return;
        hp -= Random.Range(8,15);
        if (hp <= 0)
        {
			other.addScore(score1);
			//S.addScore(score1);
            AudioSource.PlayClipAtPoint(tankExplosionAudio, transform.position);
            GameObject.Instantiate(tanExplosion, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);
			
        }

    }
}
