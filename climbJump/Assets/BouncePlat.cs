using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePlat : MonoBehaviour
{
    public float jumpF = 25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if(rb != null)
        {
            if(rb.velocity.y < 0)
            {
                return;
            }
            Vector2 velocity = rb.velocity;
            velocity.y = jumpF;
            rb.velocity = velocity;
        }
    }

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.collider.name == "DeadZone")
    //    {
    //        float randX = Random.Range(-1.7f, 1.7f);
    //        float randY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);

    //        transform.position = new Vector3(randX, randY, 0);


    //    }
    //}
}
