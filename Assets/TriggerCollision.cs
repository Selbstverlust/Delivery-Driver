using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollision : MonoBehaviour {

    bool hasPackage;
    [SerializeField] private float destructionDelay = 1f;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage) {
            Debug.Log("Package picked up.");
            hasPackage = true;
            Destroy(other.gameObject, destructionDelay);
        }
        if (other.tag == "Customer" && hasPackage) {
            Debug.Log("Package delivered.");
            hasPackage = false;
            Destroy(other.gameObject, destructionDelay);
        }
    }
}
