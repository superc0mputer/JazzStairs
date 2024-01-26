using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerActivate : MonoBehaviour
{
    [SerializeField] private GameObject toActivate;
    
    private void OnTriggerEnter(Collider other)
    {
        toActivate.SetActive(true);
    }
}
