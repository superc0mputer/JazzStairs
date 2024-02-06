using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerActivate : MonoBehaviour
{
    [SerializeField] private List<GameObject> toActivate;
    [SerializeField] private List<GameObject> toDeactivate;

    private bool state = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!state)
        {
            toActivate.ForEach(o => o.SetActive(true));
            toDeactivate.ForEach(o => o.SetActive(false));
            state = true;
        }
        else
        {
            toActivate.ForEach(o => o.SetActive(false));
            toDeactivate.ForEach(o => o.SetActive(true));
            state = false;
        }
    }
}
