using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2controller : MonoBehaviour
{
    private Rigidbody player_rigidbody;
    public float jumpStrength = 83f;
    public float gravityModifier = 9f;
    public bool isOnGround = true;
    public int scoreValue = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        // Gets the rigidbody of the player
        player_rigidbody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        // Player will jump if space is hit
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            player_rigidbody.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Checks for what gameObject the player is colliding with
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Takes it to endGame() function in GameManagerScript
            FindObjectOfType<GameManagerScript>().endGame();
        }

        else if (collision.gameObject.CompareTag("Gem"))
        {
            // Updates next scene - Final Scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
