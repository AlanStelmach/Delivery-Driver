using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 300.0f;
    [SerializeField] float moveSpeed = 20.0f;
    [SerializeField] float slowSpeed = 15.0f;
    [SerializeField] float boostSpeed = 30.0f;

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime; // Steering
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; // Movement
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && collision.tag == "BoostSpeed")
        {
            moveSpeed = boostSpeed;
        }
    }
}
