using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatJetpack : MonoBehaviour
{
    public float jumpForce = 50f;
    public GameObject player;
    public Sprite spritejetpack;
    public Sprite spriteBase;

    public float delay = 20;
    float timer;
    bool running = true;

    void Start()
    {
        
    }

    void Update()
    {
        if (running)
        {
            timer += Time.deltaTime;
            if (timer > delay)
            {
                player.gameObject.GetComponent<SpriteRenderer>().sprite = spriteBase;
                running = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
                player.gameObject.GetComponent<SpriteRenderer>().sprite = spritejetpack;
                running = true;
            }
        }
    }
}
