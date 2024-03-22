using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    //private Button button;
    private GameManager gameManager;
    public AudioClip startSound;
    [SerializeField] private SoundManager soundManager;
    [SerializeField] private AudioSource playerAudio;

    void Start()
    {
        //button = GetComponent<Button>();
        //button.onClick.AddListener(StartGame);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
        if (playerAudio == null) Debug.Log("STARRTT AUDIO NULL");
    }

    public void StartGame()
    {
        soundManager.GeneralSound(startSound);
        gameManager.StartGame();
    }

    public void ExitGame()
    {
        gameManager.Exit();
    }
}
