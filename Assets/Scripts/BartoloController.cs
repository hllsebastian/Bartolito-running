using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BartoloController : MonoBehaviour
{
    public float velocityMotionZ;
    public float velocityMotionX;
    float motionHorizontal, motionVertical;

    // Update is called once per frame
    void Update()
    {
        motionVertical = Input.GetAxis("Vertical");
        motionHorizontal = Input.GetAxis("Horizontal");

        transform.Translate(0, 0, motionVertical * Time.deltaTime * velocityMotionZ);
        transform.Rotate(0, motionHorizontal * Time.deltaTime * velocityMotionX, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player has collided with enemy.");
        }
    }

}

// //     private float speed = 30.0f;
// //     private float rotationSpeed = 30.0f;
// //     //private float jumpForce = 5.0f;
// //     //private float gravityModifier;
// //     private float zBound = 700;
// //     private Rigidbody playerRb;
// //     public GameObject collectedPowerUp;

// //     void Start()
// //     {
// //         playerRb = GetComponent<Rigidbody>();
// //         //Physics.gravity *= gravityModifier;
// //     }

// //     void FixedUpdate()
// //     {
// //         MovePlayer();
// //         ConstrainPlayerPosition();

// //         if (Input.GetKeyDown(KeyCode.Space))
// //         {
// //             ShootPowerUp();
// //         }

// //         // TODO(anyone): fix the jump, is not using the gravity although is activated on rigid body
// //         //if (Input.GetKeyDown(KeyCode.F))
// //         //{
// //         //    Jump();
// //         //    Debug.Log("JUUMMPPP");
// //         //}
// //     }

// //     void MovePlayer()
// //     {
// //         float verticalInput = Input.GetAxis("Vertical");
// //         playerRb.AddRelativeForce(Vector3.right * speed * verticalInput);

// //         float roty = Input.GetAxis("Horizontal");
// //         //playerRb.AddRelativeForce(Vector3.back * speed * horizontalInput);

// //         transform.Rotate(0, roty * rotationSpeed * Time.deltaTime, 0);
// //     }

// //     // TODO(anyone): fix the jump
// //     //void Jump()
// //     //{
// //     //    playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
// //     //}

// //     void ConstrainPlayerPosition()
// //     {
// //         if (transform.position.z < -zBound)
// //         {
// //             transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
// //         }

// //         if (transform.position.z > zBound)
// //         {
// //             transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
// //         }
// //     }

// //     private void OnCollisionEnter(Collision collision)
// //     {
// //         if (collision.gameObject.CompareTag("Enemy"))
// //         {
// //             Debug.Log("Player has collided with enemy.");
// //         }

// //     }

// //     private void OnTriggerEnter(Collider other)
// //     {
// //         if (other.gameObject.CompareTag("Powerup"))
// //         {
// //             //collectedPowerUp = other.gameObject;
// //             Destroy(other.gameObject);
// //         }

// //         if (other.gameObject.CompareTag("Egss"))
// //         {
// //             Destroy(other.gameObject);
// //         }

// //         if (other.gameObject.CompareTag("Easteregg"))
// //         {
// //             Destroy(other.gameObject);
// //         }
// //     }

// //     private void ShootPowerUp()

// //     {
// //         if (collectedPowerUp != null)
// //         {
// //             // Crea una copia del power-up en la posición del jugador
// //             Instantiate(collectedPowerUp, transform.position, Quaternion.identity);

// //             // Añade fuerza al power-up para dispararlo
// //             Rigidbody rb = collectedPowerUp.GetComponent<Rigidbody>();

// //             if (rb != null)
// //             {
// //                 rb.AddForce(transform.forward * 500);
// //             }

// //             //  Borra el power-up que tenías
// //             collectedPowerUp = null;
// //         }


// //     }



// // }