using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float timeToDestroy = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 hasNoPackageColor = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ohh no!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Nice work!");
        if(collision != null && collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, timeToDestroy);
        }
        else if(collision != null && collision.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Customer!");
            hasPackage= false;
            spriteRenderer.color = hasNoPackageColor;
        }
    }
}
