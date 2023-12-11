using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleCollide : MonoBehaviour
{
    // Start is called before the first frame update
    float Health = 50f;
    void Start()
    {

        Debug.Log("the console is working");
    }

    // Update is called once per frame


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
                other.transform.position = new Vector3(1000f, 1000f, 1000f);
                Health = 50f;
            }




        }
    }
}
