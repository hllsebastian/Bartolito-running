using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // Guarda la distancia inicial entre la cámara y el jugador
        offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Mueve la cámara para que mantenga la misma distancia respecto al jugador
        transform.position = playerTransform.position + offset;
    }
}