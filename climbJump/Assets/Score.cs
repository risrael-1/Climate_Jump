using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Transform player;
    private float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("Score", "0");
    }

    // Update is called once per frame
    void Update()
    {
        score = float.Parse(PlayerPrefs.GetString("Score"));
        if ((player.position.y + score) >= score) {
            //if (PlayerPrefs.HasKey("Score"))
            //{
                score = 0;
                score = float.Parse(PlayerPrefs.GetString("Score")) + player.position.y;
                PlayerPrefs.SetString("Score", score.ToString());
            //}
            scoreText.text = "";
            scoreText.text = score.ToString("0");
        }
        //if (player.position.y >= score)
        //{
        //    if(PlayerPrefs.HasKey("Score"))
        //    {
        //        score = player.position.y + float.Parse(PlayerPrefs.GetString("Score"));
        //    } else
        //    {
        //        score = player.position.y;
        //    }

        //    scoreText.text = "";
        //    scoreText.text = score.ToString("0");
        //}
        // else if (player.position.y + float.Parse(PlayerPrefs.GetString("Score")) >= score)
        //{

        //    score = player.position.y + float.Parse(PlayerPrefs.GetString("Score"));

        //}
    }
}
