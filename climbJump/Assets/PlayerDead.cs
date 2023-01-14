using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour
{

    public GameObject player;
    public Text score;
    void Start()
    {
       
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject != null)
        {
            int HighScore;
            PlayerPrefs.SetString("CurrentScore", score.text);

            HighScore = int.Parse(PlayerPrefs.GetString("HighScore"));
            if (int.Parse(score.text) > HighScore)
            {
                PlayerPrefs.SetString("HighScore", score.text);
                
            }
            SceneManager.LoadScene("Score");
        }
    }
}
