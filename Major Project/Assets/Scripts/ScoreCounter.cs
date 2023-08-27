using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // This updates the score
        score.text = "Score : " + scoreValue;

        // This checks if the player has scored over 50 points
        if (scoreValue >= 50)
        {
            Debug.Log("You defeated the aliens");
            // Moves to next level, sets score back to 0, sets gravity for next level.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            scoreValue = 0;
            Physics.gravity = new Vector3(0, -9, 0);
        }
    }
}
