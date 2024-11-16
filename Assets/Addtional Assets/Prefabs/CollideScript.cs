using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideScript : MonoBehaviour
{
    public float forceAmount = 20f;
    public Vector3 forceDirection = Vector3.forward; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody playerRigidbody = other.GetComponent<Rigidbody>();
            if (playerRigidbody != null)
            {
                playerRigidbody.AddForce(forceDirection.normalized * forceAmount, ForceMode.Impulse);
            }

            Destroy(gameObject);
        }
    }
}
