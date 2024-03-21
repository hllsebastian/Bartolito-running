using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GamePaused : MonoBehaviour
{
    public static bool isPaused;

    private void Start()
    {
        isPaused = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("PAUUSSEDDD");
            PausedGame();
        }
    }

    public void PausedGame()
    {
        if (!isPaused)
        {
            isPaused = true;
            Time.timeScale = 0;
            //Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Debug.Log("CONTINUUEEE");
            isPaused = false;
            Time.timeScale = 1;
            //Cursor.lockState = CursorLockMode.Locked;
        }

    }
}
