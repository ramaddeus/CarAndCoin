using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMarkup : MonoBehaviour
{
   ObjectPooler objectPooler;
    
    void Start()
    {
        StartCoroutine(WaitingSpawn());
    }

    IEnumerator WaitingSpawn()
    {
        yield return new WaitForSeconds(0.25f);
        ObjectPooler.Instance.SpawnFromPool("Markup", transform.position, Quaternion.identity);
        Repeat();
    }

    void Repeat()
    {
        StartCoroutine(WaitingSpawn());
    }
}


