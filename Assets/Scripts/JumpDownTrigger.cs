using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpDownTrigger : MonoBehaviour
{

    [SerializeField] AudioClip music;
    [SerializeField] string scene;

    
    private AudioSource audioPlayer;
    private SceneSwticher jumpDownTeleporter;

    // Start is called before the first frame update
    void Start()
    {        
        audioPlayer = GameObject.FindWithTag("Player").GetComponent<AudioSource>();
        jumpDownTeleporter = GameObject.FindWithTag("Teleporter").GetComponent<SceneSwticher>();
    }

    private void OnTriggerEnter(Collider other)
    {
        /*
        if (audioPlayer.clip != music)
        {
            Debug.Log("Changed Sound to: " + audioPlayer.clip.name);
            audioPlayer.Stop();
            audioPlayer.clip = music;
            audioPlayer.Play(0);
            StartCoroutine(WaitUntilMusicIsDone());
        }
        */
        
        if (audioPlayer.clip != music)
        {
            Debug.Log("Changed Sound to: " + audioPlayer.clip.name);
            audioPlayer.Stop();
            audioPlayer.clip = music;
            audioPlayer.Play(0);
            jumpDownTeleporter.musicPlayed = true;
        }
        
    }
    
    
    IEnumerator WaitUntilMusicIsDone()
    {
        yield return new WaitUntil(() => !audioPlayer.isPlaying);
        SceneManager.LoadScene(scene);

    }
    
    
}
