using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Get the mouse position in world coordinates
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Calculate the direction from the object to the mouse position
        Vector3 direction = mousePosition - transform.position;

        // Calculate the rotation to look at the mouse
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        // Apply the rotation to the object
        transform.rotation = rotation;
    }
}


