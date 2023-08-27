using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Des : MonoBehaviour

{
    // Setting private bounds
    private float topBound = 40;
    private float lowerBound = -23;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroys gameobjects that go out of these set bounds
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
