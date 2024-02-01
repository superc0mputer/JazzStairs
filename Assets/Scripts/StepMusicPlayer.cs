using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepMusicPlayer : MonoBehaviour
{
    private AudioSource audioPlayer;

    [SerializeField] private AudioClip sound;

    private void Start()
    {
        audioPlayer = GameObject.FindWithTag("Player").GetComponent<AudioSource>();
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (audioPlayer.clip != null)
        {
            audioPlayer.Stop();
            //Debug.Log("Stopped Sound: " + audioPlayer.clip.name);
        }

        audioPlayer.clip = sound;
        //Debug.Log("Changed Sound to: " + audioPlayer.clip.name);
        audioPlayer.Play(0);
        audioPlayer.time = 0.5f;
    }
    
}
