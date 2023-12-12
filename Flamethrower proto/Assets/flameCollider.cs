using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class flameCollider : MonoBehaviour
{
    // Start is called before the first frame update
    float Health = 1f;
    // Define the bounds
    float minX = -8.34f;
    float maxX = 8.26f;
    float minY = -3.44f;
    float maxY = 3.57f;
    [SerializeField] private TMP_Text scoreUI;
    [SerializeField] private GameObject[] enemy;
    private int score;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = "Score: " + score;
        if (score >= 10)
        {
            enemy[1].SetActive(true);
        }

        if (score >= 20)
        {
            enemy[2].SetActive(true);
        }
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
                score++;
            }
        }
    }
}
