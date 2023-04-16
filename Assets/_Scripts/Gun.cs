using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform clovesSpawn;
    public GameObject clovesPrefab;
    public float speed = 30;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            var cloves = Instantiate(clovesPrefab, clovesSpawn.position, Quaternion.identity);
            cloves.GetComponent<Rigidbody>().velocity = transform.up * speed;
        }
    }
}
