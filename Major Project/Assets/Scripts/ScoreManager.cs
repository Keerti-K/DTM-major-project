using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void AddScore(int amount)
    {
       // Adds a certain amount onto the score
        ScoreCounter.scoreValue += amount;
    }

}
