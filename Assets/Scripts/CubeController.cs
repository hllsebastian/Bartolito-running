using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private GameManager gameManager;
    private Rigidbody playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }


    void FixedUpdate()
    {
      
        if (gameManager.isGameActive && !GamePaused.isPaused)
        {
            playerRb.AddRelativeForce(Vector3.right * Time.deltaTime * 1000);
        }        
    }
}
