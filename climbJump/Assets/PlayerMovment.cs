using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovment : MonoBehaviour
{
    public SpriteRenderer player;
    private Rigidbody2D rb;
    private float moveX;
    private float speed = 10f;
    Vector2 position;
    float radius;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //moveX = Input.GetAxis("Horizontal") * speed;
        moveX = Input.acceleration.x * speed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);
      
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;

        if ((rb.position.x) > Const.screenLimitX)
        {
            velocity.x = -Const.screenLimitX;
            velocity.y = rb.position.y;
            rb.position = velocity;
        }

        if ((rb.position.x) < -Const.screenLimitX)
        {
            velocity.x = Const.screenLimitX;
            velocity.y = rb.position.y;
            rb.position = velocity;
        }       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("hole"))
        {
            rb.velocity = Vector2.zero;
        }
    }
}
