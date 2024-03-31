using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    private GameManager gameManager;
    public AudioClip startSound;
    [SerializeField] private SoundManager soundManager;
    public AudioSource playerAudio;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
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
