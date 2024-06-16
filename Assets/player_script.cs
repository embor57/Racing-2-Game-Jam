using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{


    public Rigidbody2D carRigid;
    public float movespeed;
    public BoxCollider2D boxCollid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKey(KeyCode.W))
        {
            carRigid.velocity = new Vector2(0,2);
        }

    }
}
