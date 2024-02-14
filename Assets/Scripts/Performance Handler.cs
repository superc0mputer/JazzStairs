using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PerformanceHandler : MonoBehaviour
{
    public List<Performance> performanceObjects;

    // Update is called once per frame
    void Start()
    {
        for (int i = 0; i < performanceObjects.Count; i++)
        {
            StartCoroutine(WaitSeconds(performanceObjects[i].objectsToActivate, performanceObjects[i].time,performanceObjects[i].setActive));
            Debug.Log(i);
        }
    }
    
    IEnumerator WaitSeconds(List<GameObject> objectsToActivate, float time, bool setActive)
    {
        yield return new WaitForSeconds(time);
        objectsToActivate.ForEach(o => o.SetActive(setActive));
    }
}
