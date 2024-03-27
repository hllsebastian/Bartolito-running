using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gamePausedCanvas;
    [SerializeField] private bool isPaused;
    private string firstLevel = "SampleScene";
    public bool isGameActive;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausedGame();
        }
    }

    public void StartGame()
    {
        isGameActive = true;
        //gameOptions.SetActive(false);

        SceneManager.LoadScene(firstLevel);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PausedGame()
    {
        if (!isPaused)
        {
            Debug.Log("PAUUSSEDDD");
            isPaused = true;
            Time.timeScale = 0;
            gamePausedCanvas.SetActive(true);
        }
        else
        {
            Debug.Log("CONTINUUEEE");
            isPaused = false;
            Time.timeScale = 1;
            gamePausedCanvas.SetActive(false);
        }
    }

    public void Exit()
    {
        Debug.Log("EXIIITTT");
        Application.Quit();
    }
}