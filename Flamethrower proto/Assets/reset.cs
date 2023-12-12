using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class reset : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 initialPos;
    [SerializeField] private Transform playPos;
    public float speed;
    public GameObject player;
    [SerializeField] private TMP_Text retryUI;
    [SerializeField] private GameObject gameOverScreen;
    private int retryCount;
    private Vector3 playerInitialPos;
    public Rigidbody2D rb;
    

    void Start()
    {
        initialPos = transform.position;
        retryCount = 3;
        gameOverScreen.SetActive(false);
        playerInitialPos = playPos.position;
        rb = player.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        retryUI.text = "Retrys: x"+retryCount;

        float distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        speed = Random.Range(1, 4);

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.T))
        {
            rb.drag = 1000;
            rb.angularDrag = 1000;
            playPos.position = playerInitialPos;
            transform.position = initialPos;
            StartCoroutine(delayDragFix());
            retryCount--;
            if (retryCount < 0)
            { 
                gameOverScreen.SetActive(true);
            }
        }
    }

    private IEnumerator delayDragFix()
    {
        yield return new WaitForSeconds(1);
        rb.drag = 0.3f;
        rb.angularDrag = 0.05f;
    }



}
