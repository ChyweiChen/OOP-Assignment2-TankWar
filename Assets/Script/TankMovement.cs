using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

    public float speed = 5;
    public float angularSpeed = 20;
    public int number = 1; //judge a player by different number 
    private new Rigidbody rigidbody;
    private TankAttack ta;
    public AudioClip idleAudio;
    public AudioClip drivingAudio;

    public AudioSource audio;
    // Use this for initialization

    void Start() {
        rigidbody = this.GetComponent<Rigidbody>();
        audio = this.GetComponent<AudioSource>();
        ta = GetComponent<TankAttack>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ta.Shoot();
        }
    }

    float Add_Speed()
    {
        speed += 5;
        Invoke("Reduce_Speed", 10);
        return speed;
    }
    float Reduce_Speed()
    {
        speed -= 5;
        return speed;
    }

    void FixedUpdate()
    {
        float v = Input.GetAxis("Verticalplayer"+number);
        rigidbody.velocity = transform.forward * v * speed; //Fore-and-aft movement speed

        float h = Input.GetAxis("player" + number + "Horizontal");
        rigidbody.angularVelocity = transform.up * h * angularSpeed; //rotational speed 

        //when tank is runing
        if (Mathf.Abs(h) > 0.1 || Mathf.Abs(v) > 0.1)
        {
            audio.clip = drivingAudio;
            audio.volume = 0.2f;
            if(audio.isPlaying == false)
            audio.Play();
        }
        else {
            audio.clip = idleAudio;
            audio.volume = 0.2f;
            if (audio.isPlaying == false)
                audio.Play();
        }
    }

}
