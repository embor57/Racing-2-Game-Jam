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
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * movespeed * Time.deltaTime;
            myRigidBody.rotation = -90;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.up * movespeed * Time.deltaTime;
            myRigidBody.rotation = 0;

        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * movespeed * Time.deltaTime;
            myRigidBody.rotation = 90;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.down * movespeed * Time.deltaTime;
            myRigidBody.rotation = 180;


        }
    }
}