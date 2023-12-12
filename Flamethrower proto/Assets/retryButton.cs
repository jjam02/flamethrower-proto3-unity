using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class retryButton : MonoBehaviour
{
    [SerializeField] private Button _retry;
    // Start is called before the first frame update
    void Start()
    {
        _retry.onClick.AddListener(resetScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void resetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
