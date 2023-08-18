using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSideToSide : MonoBehaviour
{
    public float speed = 5f;
    private float sideBound1 = -36f;
    private float sideBound2 = -12f;
    private bool hasAdjustedDownward = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);

        if (transform.position.x < sideBound1 || transform.position.x > sideBound2)
        {
            if (!hasAdjustedDownward)
            {
                speed = -speed;
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 8);
                hasAdjustedDownward = true;
            }
        }
        else
        {
            hasAdjustedDownward = false; 
        }
    }
}
