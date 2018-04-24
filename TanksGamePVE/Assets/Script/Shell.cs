using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {

    public GameObject shellExplosionPrefab;

    public AudioClip shellExplosionAudio;



    public void OnTriggerEnter(Collider collider)
    {
        AudioSource.PlayClipAtPoint(shellExplosionAudio, transform.position);
        GameObject.Instantiate(shellExplosionPrefab, transform.position, transform.rotation);
        GameObject.Destroy(this.gameObject);

        if (collider.tag == "Player" || collider.tag == "Enemy")  //when shell touch tank
        {
            collider.SendMessage("TakeDamage");
        }
    }
}
