using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Curb")
        {
            Debug.Log("enter");
        }

        if (collision.gameObject.name == "Curb")
        {
            Debug.Log("stay");
        }

        if (collision.gameObject.name == "Curb")
        {
            Debug.Log("exit");
        }

        if (collision.gameObject.name == "hole")
        {

        }
        if (collision.gameObject.name == "banana")
        {

        }
    }
}
