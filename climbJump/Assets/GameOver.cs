using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text score;
    public Text hightScore;

    void Start()
    {
        hightScore.text = PlayerPrefs.GetString("HighScore");
        score.text = PlayerPrefs.GetString("CurrentScore");
    }

    void Update()
    {
        
    }
}
