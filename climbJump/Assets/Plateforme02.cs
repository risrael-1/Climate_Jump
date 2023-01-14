using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plateforme02 : MonoBehaviour
{

    public float jumpForce = 10f;
    public Text score;
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
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {

                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
                if (rb.tag == "plato2")
                {

                    int currentScore = int.Parse(score.text);
                    currentScore += 100;
                    PlayerPrefs.SetString("Score", currentScore.ToString());
                    score.text = currentScore.ToString();
                } else
                {
                    int currentScore = int.Parse(score.text);
                    currentScore += 500;
                    PlayerPrefs.SetString("Score", currentScore.ToString());
                    score.text = currentScore.ToString();
                }
            }
        }
    }
}
