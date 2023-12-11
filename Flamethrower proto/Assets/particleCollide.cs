using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleCollide : MonoBehaviour
{
    // Start is called before the first frame update
    float Health = 50f;
    // Define the bounds
    float minX = -8.34f;
    float maxX = 8.26f;
    float minY = -3.44f;
    float maxY = 3.57f;
    void Start()
    {

        Debug.Log("the console is working");
    }

    // Update is called once per frame

    void Update()
    {
        Debug.Log(Health);
    }

    void OnParticleCollision(GameObject other)
    {
        // Check if the collision involves an object with the "Enemy" tag
        if (other.CompareTag("enemy"))
        {
            // Your custom behavior when the particle collides with an enemy
            Debug.Log("Particle collided with enemy: " + other.name);
            Health -= 0.5f;

            if (Health <= 0)
            {
                float randomX = Random.Range(minX, maxX);
                float randomY = Random.Range(minY, maxY);

                other.transform.position = new Vector3(randomX, randomY, 0f);
                Health = 50f;
            }




        }
    }
}
