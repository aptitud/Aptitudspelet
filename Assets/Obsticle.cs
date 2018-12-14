using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Obsticle : MonoBehaviour
{
    public float movementSpeed = 10f;
    private Rigidbody2D rigidBody;
    private float movement = 10f;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    }

    private void FixedUpdate()
    {
        var velocity = rigidBody.velocity;
        velocity.x = -movement;
        rigidBody.velocity = velocity;
    }
}
