using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.velocity = new Vector3(other.attachedRigidbody.velocity.x, 0, other.attachedRigidbody.velocity.z);
        other.attachedRigidbody.AddForce(Vector3.up * 1000);
    }
}
