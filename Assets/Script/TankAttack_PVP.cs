using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack_PVP : MonoBehaviour {
    public GameObject shellPrefab;
    private Transform fireposition;
    public float shellSpeed = 10;
    public KeyCode firekey = KeyCode.Space;

    public AudioClip ShotAudio;
    private AudioSource fireAudio;
    // Use this for initialization
    void Start () {
        fireposition = transform.Find("FirePosition");
    }
	
	// Update is called once per frame
	void Update () {
        fireAudio = this.GetComponent<AudioSource>();
        if (Input.GetKeyDown(firekey))
        {
            fireAudio.volume = 1.0f;
            fireAudio.Play();
            AudioSource.PlayClipAtPoint(ShotAudio, transform.position);
            GameObject go = GameObject.Instantiate(shellPrefab, fireposition.position, fireposition.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;

        }
    }
}
