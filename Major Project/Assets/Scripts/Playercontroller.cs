using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour

{
    public float horizontalInput;
    public float speed = 10.0f;
    public float rightBoundary = 25.0f;
    public float leftBoundary = -25.0f;
    // Cooldown and delay time for laser shooting
    public float cooldownTime = 0.5f;
    private float lastShotTime = 0.0f;

    // This is where the laser will go
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Keeps object in bound
        if (transform.position.x < leftBoundary)
        {
            transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z);
        }

        if (transform.position.x > rightBoundary)
        {
            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
        }
        // Moves object left or right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.down * horizontalInput * Time.deltaTime * speed);

        // Checks to see if user has pressed space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float current_time = Time.time;

            // Checks cooldown time, then shoots laser
            if (current_time - lastShotTime >= cooldownTime)
            {
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
                lastShotTime = current_time;
            }
        }
    }
}
