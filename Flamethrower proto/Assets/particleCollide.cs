using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleCollide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        void OnParticleCollision(GameObject other)
        {
            // Check if the collision involves an object with the "Enemy" tag
            if (other.CompareTag("enemy"))
            {
                // Your custom behavior when the particle collides with an enemy
                Debug.Log("Particle collided with enemy: " + other.name);

                // Add your custom logic here, such as damaging the enemy, triggering effects, etc.
                // Example: other.GetComponent<EnemyScript>().TakeDamage();
            }
        }
    }
}
