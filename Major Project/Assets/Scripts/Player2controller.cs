using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2controller : MonoBehaviour
{
    private Rigidbody player_rigidbody;
    public float jumpStrength;
    public float gravityModifier;
    public bool isOnGround = true;
    
    // Start is called before the first frame update
    void Start()
    {
        player_rigidbody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            player_rigidbody.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
