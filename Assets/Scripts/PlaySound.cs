using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlaySound : MonoBehaviour
{

    public AudioSource[] sound;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !sound[0].isPlaying && !sound[1].isPlaying)
        {
            var play = new System.Random();
            if(play.Next(2) == 0)
            {
                sound[0].Play();
            }
            else
            {
                sound[1].Play();
            }
            
            
        }
    }
}
