using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {

    public Slider slider;
    public int damage =0;
    public int hp = 100;
    public int Max_hp = 100;
    public int score1 = 1;
    public GameObject tanExplosion;
    public AudioClip tankExplosionAudio;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    int Add_Health()
    {
        hp += 10;
        Invoke("Reduce_Health",0.1f);
        slider.value = hp;
        return hp;
    }
    float Reduce_Health()
    {
        if (hp >= Max_hp)
        {
            hp = Max_hp;
        }
        return hp;
    }
    int Add_Damage()
    {
        damage += 5;
        Invoke("Reduce_Damage", 10);
        return damage;
    }
    float Reduce_Damage()
    {
        damage -= 5;
        return damage;
    }

    void TakeDamage()
    {
        GameObject go = GameObject.Find("ScoreControler");
        Score other = (Score)go.GetComponent(typeof(Score));

        if (hp <= 0) return;
        hp = hp - (8 + damage);
        slider.value = hp;
        if (hp <= 0)
        {
            other.addScore(score1);
            AudioSource.PlayClipAtPoint(tankExplosionAudio, transform.position);
            GameObject.Instantiate(tanExplosion, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);
        }

    }
    void TakeDamage_PVP()
    {
        if (hp <= 0) return;
        hp = hp - (8 + damage);
        slider.value = hp;
        if (hp <= 0)
        {
            AudioSource.PlayClipAtPoint(tankExplosionAudio, transform.position);
            GameObject.Instantiate(tanExplosion, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);
        }

    }

}
