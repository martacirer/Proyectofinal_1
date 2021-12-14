using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (gameObject.CompareTag("Obstacle") && otherCollider.gameObject.CompareTag("Player"))
        {
            Debug.Log($"GAME OVER");
            Time.timeScale = 0;
        }
        

        
    }
}
