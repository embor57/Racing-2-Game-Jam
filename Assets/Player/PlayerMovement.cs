using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float movespeed = .05f;
    public bool flipUp = false;
    public bool flipSide = false;
    public SpriteRenderer spriteRenderer;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.position += Vector3.up * movespeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * movespeed * Time.deltaTime;
            myRigidBody.rotation = -90;
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += Vector3.up * movespeed * Time.deltaTime;
            myRigidBody.rotation = 0;

        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * movespeed * Time.deltaTime;
            myRigidBody.rotation = 90;
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.down * movespeed * Time.deltaTime;
            myRigidBody.rotation = 180;


        }
    }
}