using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManagerScript : MonoBehaviour
{
    public TextMeshProUGUI CoinScore;
    public static int Score = 0;
    private void FixedUpdate()
    {

        CoinScore.text = Score.ToString();

    }

    public static void AddScore()
    {
        Score++;


    }


}


