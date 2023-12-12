using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float forceMultiplier = 10f;

    private Vector3 initialPos;

    void Start()
    {
        initialPos = transform.position;
    }

    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButton(0)) // 0 corresponds to the left mouse button
        {
            // Get the mouse position in world coordinates
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Calculate the direction from the player to the mouse position
            Vector3 direction = mousePosition - transform.position;

            // Normalize the direction to get a unit vector
            direction.Normalize();

            // Apply force in the opposite direction of the cursor position
            GetComponent<Rigidbody2D>().AddForce(-direction * forceMultiplier);
        }

        // Move the player based on input (optional)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);
        transform.position += movement * moveSpeed * Time.deltaTime;


    }
}

