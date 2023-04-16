using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public GameObject room;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Clove"))
        {
            health--;
            if (health <= 0)
            {
                room.GetComponent<EnemySpawner>().EnemyKilled();
                Destroy(gameObject);
            }
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            health--;
        }
    }
}
