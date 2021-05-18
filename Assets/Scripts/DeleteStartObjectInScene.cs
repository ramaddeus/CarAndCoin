using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteStartObjectInScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(WaitingSpawn());
    }

    IEnumerator WaitingSpawn()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
