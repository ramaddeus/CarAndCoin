using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBuilds : MonoBehaviour
{
    ObjectPooler objectPooler;
    
    void Start()
    {
        StartCoroutine(WaitingSpawn());
    }

    IEnumerator WaitingSpawn()
    {
        yield return new WaitForSeconds(Random.Range(0.1f, 0.4f));
        if (Random.Range(0.0f, 1.0f) > 0.5f)
        {
            ObjectPooler.Instance.SpawnFromPool("Build1", transform.position, Quaternion.identity);
        }
        else ObjectPooler.Instance.SpawnFromPool("Build2", transform.position, Quaternion.identity);
        Repeat();
    }

    void Repeat()
    {
        StartCoroutine(WaitingSpawn());
    }
}
