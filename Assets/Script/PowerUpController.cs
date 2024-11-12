using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player")) //compare
        { 
            Player player = other.GetComponent<Player>();
            PowerUp powerUp = GetComponent<PowerUp>();// polymor

            if (powerUp != null && player != null)
            { 
                powerUp.ApplyPowerUp(player);
                Destroy(gameObject);
            }
        }
    }
}
