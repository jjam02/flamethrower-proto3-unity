using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleFlame : MonoBehaviour
{
    public GameObject objectToToggle;
    // Start is called before the first frame update
    void Start()
    {
        objectToToggle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            objectToToggle.SetActive(true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            objectToToggle.SetActive(false);
        }
    }
}
