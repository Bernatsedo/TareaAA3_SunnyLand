using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateAudioController : MonoBehaviour
{
    public AudioSource audioSourceWoimp;
    public AudioSource audioSourceWorumb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
               
    }
     private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSourceWorumb.Play();
        audioSourceWoimp.Play();  

    }
}
