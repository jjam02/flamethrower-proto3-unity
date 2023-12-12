using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float forceMultiplier = 10f;

    [SerializeField]
    private GameObject[] enemies;

    private Vector3 initialPos;

    private Camera mainCamera;
    private float playerHeight;
    private float playerWidth;
    // Define the bounds
    float minX = -8.34f;
    float maxX = 8.26f;
    float minY = -3.44f;
    float maxY = 3.57f;

    public int enemiesHit = 0;

    void Start()
    {
        mainCamera = Camera.main;
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

        // Check if the player is below the camera's bottom edge
        if (transform.position.y < mainCamera.transform.position.y - mainCamera.orthographicSize - playerHeight / 2)
        {
            // Reposition the player at the top of the camera
            RepositionPlayerAtTop();
        }

        if (transform.position.x > mainCamera.transform.position.x + mainCamera.orthographicSize * mainCamera.aspect + playerWidth / 2)
        {
            // Reposition the player on the left side of the camera
            RepositionPlayerAtLeft();
        }
        // Check if the player is above the camera's top edge
        if (transform.position.y > mainCamera.transform.position.y + mainCamera.orthographicSize + playerHeight / 2)
        {
            // Reposition the player at the bottom of the camera
            RepositionPlayerAtBottom();
        }

        //Check if the player is beyond the camera's left edge
        if (transform.position.x < mainCamera.transform.position.x - mainCamera.orthographicSize * mainCamera.aspect - playerWidth / 2)
        {
            // Reposition the player on the right side of the camera
            RepositionPlayerAtLeft();
            Debug.Log("LEFT WALL");
        }

        // Move the player based on input (optional)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);
        transform.position += movement * moveSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = initialPos;
        }
    }

    void RepositionPlayerAtTop()
    {
        // Calculate the new position at the top of the camera
        float newY = mainCamera.transform.position.y + mainCamera.orthographicSize + playerHeight / 2;

        // Reposition the player
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        repositionEnemies();
    }

    void RepositionPlayerAtLeft()
    {
        // Calculate the new position on the left side of the camera
        float newX = mainCamera.transform.position.x - mainCamera.orthographicSize * mainCamera.aspect - playerWidth / 2;

        // Reposition the player
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);


        repositionEnemies();
    }

    void RepositionPlayerAtBottom()
    {
        // Calculate the new position at the bottom of the camera
        float newY = mainCamera.transform.position.y - mainCamera.orthographicSize - playerHeight / 2;

        // Reposition the player
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        repositionEnemies();
    }

    void RepositionPlayerAtRight()
    {
        // Calculate the new position on the right side of the camera
        float newX = mainCamera.transform.position.x + mainCamera.orthographicSize * mainCamera.aspect + playerWidth / 2;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        repositionEnemies();
    }


    void repositionEnemies()
    {
        foreach (GameObject enemy in enemies)

        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            enemy.transform.position = new Vector3(randomX, randomY, 0f);
        }
    }
}


