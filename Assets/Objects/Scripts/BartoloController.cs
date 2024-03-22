using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BartoloController : MonoBehaviour
{
    private float speed = 10.0f;
    private float zBound = 700;
    private Rigidbody playerRb;
    public GameObject collectedPowerUp;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayer();
       ConstrainPlayerPosition();
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
          ShootPowerUp();
        }
    } 

    void MovePlayer()
    {
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        float horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    void ConstrainPlayerPosition()
    {
     if (transform.position.z < -zBound)
       {
        transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
       }

     if (transform.position.z > zBound)
       {
        transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
       }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player has collided with enemy.");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Powerup"))
        {
            //collectedPowerUp = other.gameObject;
            Destroy(other.gameObject);
        }

        if(other.gameObject.CompareTag("Egss"))
        {
            Destroy(other.gameObject);
        }

        if(other.gameObject.CompareTag("Easteregg"))
        {
            Destroy(other.gameObject);
        }
    }
    
     private void ShootPowerUp()
        
     {
         if (collectedPowerUp != null)
        {
            // Crea una copia del power-up en la posición del jugador
            Instantiate(collectedPowerUp, transform.position, Quaternion.identity);

            // Añade fuerza al power-up para dispararlo
            Rigidbody rb = collectedPowerUp.GetComponent<Rigidbody>();
           
            if (rb != null)
            {
               rb.AddForce(transform.forward * 500);
            }

         //  Borra el power-up que tenías
             collectedPowerUp = null;
         }


     }

    

}