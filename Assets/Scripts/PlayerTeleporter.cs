using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleporter : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 skyPlayerTeleporter;
    private GameObject player;
    private AudioSource audioPlayer;


    void Start()
    {
        skyPlayerTeleporter = GameObject.FindWithTag("PlayerTeleporter").transform.position;
        player = GameObject.FindWithTag("Player");
        audioPlayer = GameObject.FindWithTag("Player").GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (audioPlayer.isPlaying)
        {
            player.transform.position = skyPlayerTeleporter;
        }
    }
}
