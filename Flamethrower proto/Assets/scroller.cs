using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroller : MonoBehaviour
{
    public float scrollSpeed = 5f;
    public GameObject backgroundPrefab;

    private Transform backgroundClone;

    void Start()
    {
        // Instantiate the clone and position it just below the original background
        backgroundClone = Instantiate(backgroundPrefab).transform;
        backgroundClone.position = new Vector2(0f, 10f);
    }

    void Update()
    {
        // Move the original background down based on the scroll speed
        transform.Translate(Vector2.up * scrollSpeed * Time.deltaTime);

        // Move the clone down as well
        backgroundClone.Translate(Vector2.up * scrollSpeed * Time.deltaTime);

        // Check if the original background has moved out of view
        if (transform.position.y > 10f)
        {
            // Reset the position to be just below the clone
            transform.position = new Vector2(0f, backgroundClone.position.y - 10f);
        }

        // Check if the clone has moved out of view
        if (backgroundClone.position.y > 10f)
        {
            // Reset the position to be just below the original background
            backgroundClone.position = new Vector2(0f, transform.position.y - 10f);
        }
    }
}

