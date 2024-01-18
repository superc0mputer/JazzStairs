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
        Debug.Log("Trigger");
        audioPlayer.clip = sound;
        audioPlayer.Play(0);
    }
    
}
