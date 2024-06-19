using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public string nextScene;
    public GameObject coll;
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

        if (collision.gameObject.tag == "Player")
        {
            Instantiate(coll);
            SceneManager.LoadScene(nextScene);
            Debug.Log("stay");
        }
    }
}
