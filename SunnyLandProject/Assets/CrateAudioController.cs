using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateAudioController : MonoBehaviour
{
    AudioSource[] allAudioSources;
    AudioSource Woimp;
    AudioSource Worumb;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
       
        allAudioSources = GetComponents<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        Woimp = allAudioSources[0];
        Worumb = allAudioSources[1];
    }

    // Update is called once per frame
    void Update()
    {
               
    }
     private void OnCollisionEnter2D(Collision2D collision)
    {
        Worumb.Play();
        Woimp.Play();  

    }
}
