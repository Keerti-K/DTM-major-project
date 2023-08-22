using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    bool gameHasEnded = false;
    public float delayRestart = 1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void endGame()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("Level Restarting");
            gameHasEnded = true;
            Invoke("Restart", delayRestart);
            
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ScoreCounter.scoreValue = 0;
    }
}
