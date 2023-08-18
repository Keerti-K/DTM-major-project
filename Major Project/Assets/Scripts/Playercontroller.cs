using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour

{
    public float horizontalInput;
    public float speed = 10.0f;
    public float rightBoundary = 25.0f;
    public float leftBoundary = -25.0f;
    public float cooldownTime = 0.5f;

    private float lastShotTime = 0.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftBoundary)
        {
            transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z);
        }

        if (transform.position.x > rightBoundary)
        {
            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.down * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float current_time = Time.time;

            if (current_time - lastShotTime >= cooldownTime)
            {
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
                lastShotTime = current_time;
            }
        }
    }
}
