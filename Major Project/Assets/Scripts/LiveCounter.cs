using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveCounter : MonoBehaviour
{
    // Setting number of lives and images
    public int lives = 3;
    public RawImage[] livesUI;



    private void OnTriggerEnter(Collider other)
    {
        // If the spaceship collidies with the object below the screen, you lose a live
        if (other.gameObject.CompareTag("Enemy_spaceships"))
        {
            // Destroys object and takes away a life
            Destroy(other.gameObject);
            lives -= 1;
            for (int i = 0; i < livesUI.Length; i++)
            {
                if (i < lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            // If you have 0 lives, it calls endGame() from GameManagerScript, which restarts the game
            if (lives <= 0)
            {
                FindObjectOfType<GameManagerScript>().endGame();
            }
        }
    }

}
