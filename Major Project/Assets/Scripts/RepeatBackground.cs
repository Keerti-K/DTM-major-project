using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    
    // Start is called before the first frame update
    void Start()
    {
        // Gets starting position
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Takes it back to the starting position after it crosses a certain point
        if (transform.position.x < startPos.x - 190)
        {
            transform.position = startPos;
        }
    }
}
