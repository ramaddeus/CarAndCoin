using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBackground : MonoBehaviour
{
    ObjectPooler objectPooler;
    
    void Start()
    {
        
        StartCoroutine(StartWaiting());
        
    }
    IEnumerator StartWaiting()
    {
        yield return new WaitForSeconds(0.015f);
        StartCoroutine(WaitingSpawn());
    }
    IEnumerator WaitingSpawn()
    {
        ObjectPooler.Instance.SpawnFromPool("Background", transform.position, Quaternion.identity);
        yield return new WaitForSeconds(3.315f);
        Repeat();
    }

    void Repeat()
    {
        StartCoroutine(WaitingSpawn());
    }
}
