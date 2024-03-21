using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(StartGame);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void StartGame()
    {
        gameManager.StartGame();
    }

}
