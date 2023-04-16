using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Cloves"))
        {
            health--;
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            health--;
        }
    }
}
