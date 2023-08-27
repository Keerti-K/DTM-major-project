using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    //Speed, Move direction and left bound
    public float speed = 60;
    public Vector3 movedirection = Vector3.left;
    private float left_bound = 64;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the object left
        transform.Translate(movedirection * Time.deltaTime * speed);

        // If the obstacles goes out of bounds, it is destroyed
        if (transform.position.x < left_bound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
