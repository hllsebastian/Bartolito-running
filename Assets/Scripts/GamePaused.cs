//using System.Collections;
//using System.Collections.Generic;
//using Unity.VisualScripting;
//using UnityEngine;
//using UnityEngine.UI;

//public class GamePaused : MonoBehaviour
//{
//    //public GameObject gamePausedPanel;
//    //private Button button;
//    //public AudioClip startSound;
//    //private AudioSource playerAudio;
//    public static bool isPaused;
//    [SerializeField] private GameManager gameManager;

//    private void Start()
//    {
//        //button = GetComponent<Button>();
//        //button.onClick.AddListener(PausedGame);
//        //playerAudio = GetComponent<AudioSource>();
//        isPaused = false;
//        gameManager = GetComponent<GameManager>();
//    }

//    private void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.Escape))
//        {
//            gameManager.PausedGame();
//        }
//    }

//    //private void PausedGame()
//    //{
//    //    if (!isPaused)
//    //    {
//    //        Debug.Log("PAUUSSEDDD");
//    //        isPaused = true;
//    //        Time.timeScale = 0;
//    //        gamePausedPanel.SetActive(true);
//    //        //Cursor.lockState = CursorLockMode.None;
//    //    }
//    //    else
//    //    {
//    //        Debug.Log("CONTINUUEEE");
//    //        isPaused = false;
//    //        Time.timeScale = 1;
//    //        gamePausedPanel.SetActive(false);
//    //        //Cursor.lockState = CursorLockMode.Locked;
//    //    }

//    //}
//}
