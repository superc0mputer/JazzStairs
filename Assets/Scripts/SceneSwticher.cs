using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwticher : MonoBehaviour
{
    public bool musicPlayed = false;
    [SerializeField] private string scene;
    [SerializeField] private int waitUntilTeleport = 0;

    
    private void OnTriggerEnter(Collider other)
    {
        SwtichSceneAfterMusicAsync();
    }
    
    
    public void SwtichSceneAfterMusic()
    {
        if (musicPlayed)
        {
            SceneManager.LoadScene(scene);
        }
    }
    public void SwtichSceneAfterMusicAsync()
    {
        if (musicPlayed)
        {
            StartCoroutine(WaitSeconds());
        }
    }
    
    IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(waitUntilTeleport);
        SceneManager.LoadSceneAsync(scene);

    }

}
