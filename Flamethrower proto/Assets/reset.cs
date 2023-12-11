using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 initialPos;
    public float speed;
    public GameObject player;

    void Start()
    {
        initialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        speed = Random.Range(1, 4);

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.T))
        {
            transform.position = initialPos;
        }
    }



}
