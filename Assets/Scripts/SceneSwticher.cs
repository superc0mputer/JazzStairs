using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwticher : MonoBehaviour
{
    public bool musicPlayed = false;
    [SerializeField] private string scene;
    
    private void OnTriggerEnter(Collider other)
    {
        SwtichSceneAfterMusic();
    }
    
    
    public void SwtichSceneAfterMusic()
    {
        if (musicPlayed)
        {
            SceneManager.LoadScene(scene);
        }
    }

}
