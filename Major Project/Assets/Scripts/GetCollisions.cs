using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCollisions : MonoBehaviour
{
    public int scoreValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + gameObject.name);

        if (other.gameObject.CompareTag("Enemy_spaceships")) {
            ScoreManager.Instance.AddScore(scoreValue);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
      
    }
}
