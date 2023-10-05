using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollision : MonoBehaviour {

    bool hasPackage;
    [SerializeField] private float destructionDelay = 1f;
    [SerializeField] private Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] private Color32 noPackageColor = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage) {
            Debug.Log("Package picked up.");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destructionDelay);
        }
        if (other.tag == "Customer" && hasPackage) {
            Debug.Log("Package delivered.");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            Destroy(other.gameObject, destructionDelay);
        }
    
    }
}
