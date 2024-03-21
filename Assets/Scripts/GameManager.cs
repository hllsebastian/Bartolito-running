using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOptions;
    public bool isGameActive;

    public void StartGame()
    {
        isGameActive = true;
        gameOptions.SetActive(false);
        Debug.Log("STAARRRTTT");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
