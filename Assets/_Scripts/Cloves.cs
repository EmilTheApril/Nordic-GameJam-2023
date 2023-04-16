using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloves : MonoBehaviour
{
    public float lifeTime = 3;

    private void Awake()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject); 
    }
}
