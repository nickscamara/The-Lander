using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using EZCameraShake;

[RequireComponent(typeof(Rigidbody2D))]
public class enemy : MonoBehaviour
{

    public Transform target;

    public float speed = 5f;
    public float rotateSpeed = 200f;
    public GameObject Camera;

    private Rigidbody2D rb;

    public GameObject explosion;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 direction = (Vector2)target.position - rb.position;

        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = -rotateAmount * rotateSpeed;

        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D()
    {
        // Put a particle effect here
       
            Instantiate(explosion, transform.position, transform.rotation);
            camerashake.shake();
            Destroy(explosion);
            Destroy(gameObject);
        
    }
}