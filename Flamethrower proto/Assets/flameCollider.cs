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
    controller playerController;
    void Start()
    {
        playerController = transform.root.GetComponentInChildren<controller>();
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
                playerController.enemiesHit++;
            }
        }
    }
}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class flameCollider : MonoBehaviour
// {
//     // Start is called before the first frame update
//     float Health = 1f;
//     // Define the bounds
//     float minX = -8.34f;
//     float maxX = 8.26f;
//     float minY = -3.44f;
//     float maxY = 3.57f;

//     public GameObject player;
//     controller playerController;
//     void Start()
//     {
//         controller playerController = GetComponentInParent<controller>();
//         if (playerController != null)
//         {
//             // Access the enemiesHit variable from the PlayerController script
//             int hitCount = playerController.enemiesHit;

//             // Now you can use hitCount as needed
//             Debug.Log("Enemies hit: " + hitCount);
//         }
//         else
//         {
//             Debug.LogError("PlayerController script not found in ancestors of this GameObject.");
//         }
//     }

//     // Update is called once per frame
//     void Update()
//     {

//     }

//     void OnCollisionEnter2D(Collision2D collision)
//     {
//         if (collision.gameObject.CompareTag("enemy"))
//         {

//             Health -= 1f;
//             Debug.Log(Health);
//             if (Health <= 0)
//             {
//                 playerController.enemiesHit++;

//                 float randomX = Random.Range(minX, maxX);
//                 float randomY = Random.Range(minY, maxY);

//                 collision.transform.position = new Vector3(randomX, randomY, 0f);
//                 Health = 1f;
//             }
//         }
//     }
// }

