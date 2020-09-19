using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSoundScript : MonoBehaviour
{
    Rigidbody2D rigid2D;
    // bool isCalledOnce = false;

    public AudioClip block;
    AudioSource Sound;



    // Start is called before the first frame update
    void Start()
    {
        Sound = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Cube")
        {
            GetComponent<AudioSource> ().volume = 0.3f;
            Sound.PlayOneShot(block);

        }
    }

}
