using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flameCollider : MonoBehaviour
{
    // Start is called before the first frame update
    float Health = 1f;
    // Define the bounds
    float minX = -8.34f;
    float maxX = 8.26f;
    float minY = -3.44f;
    float maxY = 3.57f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {

            Health -= 1f;
            if (Health <= 0)
            {

                float randomX = Random.Range(minX, maxX);
                float randomY = Random.Range(minY, maxY);

                collision.transform.position = new Vector3(randomX, randomY, 0f);
                Health = 1f;
            }
        }
    }
}
