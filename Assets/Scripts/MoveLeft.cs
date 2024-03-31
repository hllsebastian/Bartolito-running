using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{ 
    public float speed = 50.0f;
    private float xDestroy = -7000.0f;
    private Rigidbody objectRb;
    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objectRb.AddForce(Vector3.left * -speed);

        if(transform.position.z < xDestroy)
        {
            Destroy(gameObject);
        }


    }
}
