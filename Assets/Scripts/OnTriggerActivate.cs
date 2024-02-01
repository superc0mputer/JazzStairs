using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerActivate : MonoBehaviour
{
    [SerializeField] private GameObject toActivate;
    [SerializeField] private GameObject toDeactivate;

    private bool state = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!state)
        {
            toActivate.SetActive(true);
            toDeactivate.SetActive(false);
            state = true;
        }
        else
        {
            toActivate.SetActive(false);
            toDeactivate.SetActive(true);
            state = false;
        }
    }
}
