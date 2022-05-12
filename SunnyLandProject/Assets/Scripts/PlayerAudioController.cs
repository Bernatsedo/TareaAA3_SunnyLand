using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    AudioSource[] allAudioSources;
    AudioSource Land;
    AudioSource Jump;
    AudioSource Crouch;
    AudioSource Cherry;
    AudioSource footsteps;
   
    bool isJumping = false;
    bool isMoving = false;
   

    Rigidbody2D rb; 


    void Start()
    {
	    rb = GetComponent<Rigidbody2D>();
        allAudioSources = GetComponents<AudioSource>();
        Land = allAudioSources [0];
        Jump = allAudioSources [1];
        Crouch = allAudioSources [2];       
        Cherry = allAudioSources [3];
        footsteps = allAudioSources [4];


    }

    
    void FixedUpdate()
    {
	    float v = rb.velocity.magnitude;
        if (v>1 && !isMoving && !isJumping)
        {
            footsteps.Play();
            isMoving = true;

        }
		else if (v<1 && isMoving && !isJumping)
        {
            footsteps.Stop();
            isMoving=false;

        }
        else if (v > 1 && isMoving && isJumping)
        {
            footsteps.Stop();
            isMoving = false;

        }
    }
    

    public void OnLanding() {
        isJumping = false;
        Land.Play();
        
        print("the fox has landed");
    }
    public void OnJump()
    {
        isJumping = true;
        Jump.Play();
        print("the fox has jumped");
    }
    public void OnCrouching() {
        Crouch.Play();
        print("the fox is crouching");
    }
  
    public void OnCherryCollect() {
       Cherry.Play();
        print("the fox has collected a cherry");
    }
    
}
