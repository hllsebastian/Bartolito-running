using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfDiamonds { get; private set; }
    
    public void DiamondCollected()
    {
        // Aquí pones el código que quieres que se ejecute cuando se recoja un diamante
        Debug.Log("¡Diamante recogido!");
    }
}

