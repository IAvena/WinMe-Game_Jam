using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class belleMovement : MonoBehaviour
{
    public float speed = 10f;         // Speed of the car
    public float rotationSpeed = 100f; // Rotation speed of the car

    void Update()
    {
        // Get input from the arrow keys or WASD keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement and rotation
        float translation = verticalInput * speed * Time.deltaTime;
        float rotation = horizontalInput * rotationSpeed * Time.deltaTime;

        // Move the car forward and backward
        transform.Translate(0f, 0f, translation);

        // Rotate the car left and right
        transform.Rotate(0f, rotation, 0f);
    }
}
