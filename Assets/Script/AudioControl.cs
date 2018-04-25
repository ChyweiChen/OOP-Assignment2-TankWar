using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour {
  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void PlayAudio()
    {
        AudioSource audioPlay = GetComponent<AudioSource>();
        audioPlay.Play();
    }
}
