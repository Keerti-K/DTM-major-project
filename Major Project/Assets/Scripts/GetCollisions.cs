using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCollisions : MonoBehaviour
{
    // You can set different scores for different gameObjects with this variable
    public int scoreValue = 0;


    private void OnTriggerEnter(Collider other)
    {

        // Destroys other gameObjects with this tag and adds their designated score
        if (other.gameObject.CompareTag("Enemy_spaceships")) {
            ScoreManager.Instance.AddScore(scoreValue);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }


    }
}
