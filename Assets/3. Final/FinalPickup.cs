using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //checks if the object we collided it has a player tag (remember to set it on the player!)
        if (other.CompareTag("Player"))
        {
            FinalGameManager.instance.score += 1;
            Destroy(this.gameObject);
        }
    }
}
