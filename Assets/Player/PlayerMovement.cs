using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float Boost;
    public float right;
    public float left;
    public float up;
    public float down;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.position += Vector3.up * Boost;
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * right;
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += Vector3.up * up;
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * left;
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.down * down;
        }
    }
}