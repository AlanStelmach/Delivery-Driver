using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ohh no!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Nice work!");
        if(collision != null && collision.tag == "Package")
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
        }
        else if(collision != null && collision.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Customer!");
            hasPackage= false;
        }
    }
}
