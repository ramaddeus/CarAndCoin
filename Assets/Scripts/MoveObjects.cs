
using System.Collections;

using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public static float Speed = 60f;
    

    void Update()
    {
        transform.Translate(-1*Vector3.forward*Time.deltaTime*Speed);
    }
}
