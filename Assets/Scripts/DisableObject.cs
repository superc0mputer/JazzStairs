using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObject : MonoBehaviour
{
    [SerializeField] private int waitUntilDisable;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitSeconds());

    }

    IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(waitUntilDisable);
        this.gameObject.SetActive(false);
    }
}
