using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControls : MonoBehaviour
{
    public float movementSpeed = 10f;
    public Joystick joystick;

    private Rigidbody2D rigidBody;
    private float movement = 0f;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var movementBase = joystick.gameObject.activeSelf
            ? joystick.Vertical
            : Input.GetAxis("Vertical");

        movement = movementBase * movementSpeed;
    }

    private void FixedUpdate()
    {
        var velocity = rigidBody.velocity;
        velocity.y = movement;
        rigidBody.velocity = velocity;
    }
}
