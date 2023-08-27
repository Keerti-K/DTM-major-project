using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    bool gameHasEnded = false;
    public float delayRestart = 0.2f;

    public void endGame()
    {
        // Checks if the game has ended 
        if (gameHasEnded == false)
        {
            Debug.Log("Level Restarting");
            gameHasEnded = true;
            // Calls the restart function
            Invoke("Restart", delayRestart);
            
        }
        
    }

    void Restart()
    {
        // Restarts score, scene, and sets gravity again.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ScoreCounter.scoreValue = 0;
        Physics.gravity = new Vector3(0, - 9, 0);
    }
}
