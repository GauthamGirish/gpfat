using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput*speed, body.velocity.y);

        if (horizontalInput < 0 && transform.localScale.x > 0)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
        else if (horizontalInput > 0 && transform.localScale.x < 0)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }

        if (Input.GetKeyDown(KeyCode.Space) && Math.Abs(body.velocity.y) < 0.01)
        {
            body.velocity = new Vector2(body.velocity.x, speed);
        }
    }
}
