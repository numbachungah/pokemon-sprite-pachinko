using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDaBall : MonoBehaviour
{
    private MoveDaMime moveScript;
    private Rigidbody2D rb;
    public Transform spawn;
    private bool hasDropped = false;

    void Start()
    {
        moveScript = GetComponent<MoveDaMime>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && hasDropped == false)
        {
            moveScript.enabled = false;
            rb.gravityScale = 1;
            hasDropped = true;

        }
        else if (Input.GetKeyDown(KeyCode.Space) && hasDropped == true)
        {
            transform.position = spawn.position;
            moveScript.enabled = true;
            rb.gravityScale = 0;
            hasDropped = false;
        }
    }
}

